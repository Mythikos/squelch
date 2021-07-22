using Android.Animation;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.Widget;
using AndroidX.Fragment.App;
using Google.Android.Material.Snackbar;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Extensions;
using Squelch.Library.Interfaces;
using Squelch.Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Squelch.Fragments
{
    public class FeedbackFragment : Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(FeedbackFragment).FullName;

        // Parent view variables
        private LinearLayout _rootLayout;
        private TextView _problemLabel;
        private Button _dialogPositiveButton;
        private Button _dialogNegativeButton;
        private TextView _dataConsentLabel;

        private List<(LinearLayout, TextView, TextView, List<View>)> _questionTuples;
        private EditText _question3Response0, _question4Response0, _question5Response0; // Controls that literally hate me

        // Other garbage ;D
        private int _questionId;
        private Android.Graphics.Color _highlightColor;
        #endregion

        #region Native Events
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _highlightColor = Android.Graphics.Color.PaleGreen;
            _questionTuples = new List<(LinearLayout, TextView, TextView, List<View>)>();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            //
            // Vars
            View view = null;

            //
            // Inflate the layout
            view = inflater.Inflate(Resource.Layout.fragment_feedback, container, false);

            try
            {
                //
                // Parent view items
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_feedback_root_layout);
                _problemLabel = view.FindViewById<TextView>(Resource.Id.fragment_feedback_problem_label);
                _dataConsentLabel = view.FindViewById<TextView>(Resource.Id.fragment_feedback_data_consent_label);
                _dataConsentLabel.TextFormatted = Library.Utilities.ViewUtils.FormattedTextFromHTML(this.Resources.GetString(Resource.String.text_consent_statement));
                _dataConsentLabel.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;

                _dialogPositiveButton = view.FindViewById<Button>(Resource.Id.fragment_feedback_button_positive);
                _dialogPositiveButton.Click += PositiveButton_Click;
                _dialogNegativeButton = view.FindViewById<Button>(Resource.Id.fragment_feedback_button_negative);
                _dialogNegativeButton.Click += NegativeButton_Click;

                //
                // Question layouts
                // Get layouts
                int count = 0;
                int childCount = 0;
                while (GeneralUtils.GetResourceId(this.Context, $"fragment_feedback_question_{count}_layout", "id") != 0)
                {
                    LinearLayout layout = null;
                    TextView question = null;
                    TextView answer = null;
                    View child = null;
                    List<View> children = new List<View>();

                    // Get layout and answer container
                    layout = view.FindViewById<LinearLayout>(GeneralUtils.GetResourceId(this.Context, $"fragment_feedback_question_{count}_layout", "id"));
                    question = view.FindViewById<TextView>(GeneralUtils.GetResourceId(this.Context, $"fragment_feedback_question_{count}_text", "id"));
                    answer = view.FindViewById<TextView>(GeneralUtils.GetResourceId(this.Context, $"fragment_feedback_question_{count}_answer", "id"));

                    // get children
                    childCount = 0;
                    while (GeneralUtils.GetResourceId(this.Context, $"fragment_feedback_question_{count}_response_{childCount}", "id") != 0)
                    {
                        child = view.FindViewById(GeneralUtils.GetResourceId(this.Context, $"fragment_feedback_question_{count}_response_{childCount}", "id"));
                        child.Tag = count.ToString();
                        children.Add(child);
                        childCount++;
                    }

                    // Add layout and answer to list
                    _questionTuples.Add((layout, question, answer, children));

                    // Increment count
                    count++;
                }

                // Hookup events for controls that arent annoying
                for (int i = 0; i < _questionTuples.Count; i++)
                {
                    for (int c = 0; c < _questionTuples[i].Item4.Count; c++)
                    {
                        View child = _questionTuples[i].Item4[c];
                        if (child != null)
                            if (child is Button)
                                ((Button)child).Click += (s, e) => { ResponseFunnel(s); };
                    }
                }

                // Hookup events for controls that literally hate me (Events wont hook unless there is a reference to the control)
                _question3Response0 = view.FindViewById<EditText>(Resource.Id.fragment_feedback_question_3_response_0);
                _question4Response0 = view.FindViewById<EditText>(Resource.Id.fragment_feedback_question_4_response_0);
                _question5Response0 = view.FindViewById<EditText>(Resource.Id.fragment_feedback_question_5_response_0);
                _question3Response0.AfterTextChanged += (s, e) => { ResponseFunnel(s); };
                _question4Response0.AfterTextChanged += (s, e) => { ResponseFunnel(s); };
                _question5Response0.AfterTextChanged += (s, e) => { ResponseFunnel(s); };

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.text_feedback, false, true);

                //
                // Init view
                _questionId = -1;
                _problemLabel.Text = string.Empty;
                _dialogPositiveButton.SetText(Resource.String.text_next);
                _dialogNegativeButton.SetText(Resource.String.text_cancel);
                PositiveButton_Click(this, null);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the inflated view
            return view;
        }

        public override async void OnStart()
        {
            base.OnStart();

            //
            // Vars
            string requestResponse = string.Empty;

            try
            {
                //
                // Make a dummy test request to make sure we have a connection to the wesbite
                try { requestResponse = await GeneralUtils.SendWebRequestAsync(GetString(Resource.String.link_squelch_website), "GET", new Dictionary<string, string>()); } catch { }

                //
                // Display error if we got a blank response
                if (string.IsNullOrWhiteSpace(requestResponse))
                {
                    DisplayUtils.ShowGenericAlertDialog(this.Context, this.GetString(Resource.String.text_error), GetString(Resource.String.fragment_feedback_submission_error_unable_to_connect), false, this.GetString(Resource.String.text_ok), delegate { this.FragmentManager.PopBackStack(); });
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnStart: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        public override void OnResume()
        {
            base.OnResume();

            try
            {
                //
                // Set firebase screen
                FirebaseAnalyticsUtils.SetCurrentScreen(this);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnResume: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region Control Methods
        /// <summary>
        /// Processes the positive button click
        /// </summary>
        /// <param name="dialog"></param>
        /// <param name="which"></param>
        private void PositiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide the keyboard
                GeneralUtils.HideSoftKeyboard(this.Activity, this.Context);

                // Determine action
                if (_dialogPositiveButton.Text == GetString(Resource.String.text_next))
                    NextStep();
                else if (_dialogPositiveButton.Text == GetString(Resource.String.text_submit))
                    SubmitFeedback();
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"PositiveButton_Click: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Processes the negative button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NegativeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide the keyboard
                GeneralUtils.HideSoftKeyboard(this.Activity, this.Context);

                // Determine action
                if (_dialogNegativeButton.Text == GetString(Resource.String.text_back))
                    PreviousStep();
                else if (_dialogNegativeButton.Text == GetString(Resource.String.text_cancel))
                    ConfirmClose();
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"NegativeButton_Click: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// All answers provided to the form are funneled through here
        /// </summary>
        /// <param name="sender"></param>
        private void ResponseFunnel(object sender)
        {
            int questionId = 0;
            string answer = string.Empty;

            try
            {
                // Is the sender a view item?
                if (sender is View)
                {
                    // Is the object tagged with its question id?
                    if (int.TryParse(((View)sender).Tag?.ToString(), out questionId) == true)
                    {
                        // Get the answer
                        if (sender is Button)
                        {
                            // Set the answer
                            answer = ((Button)sender).Text;

                            // Process highlighting
                            foreach (View child in _questionTuples[questionId].Item4)
                            {
                                child.Background.Mutate();
                                child.Background.ClearColorFilter();
                            }
                            ((Button)sender).Background.Mutate();
                            ((Button)sender).Background.SetColorFilter(_highlightColor, Android.Graphics.PorterDuff.Mode.SrcAtop);
                        }
                        else if (sender is EditText)
                        {
                            answer = ((EditText)sender).Text;
                        }

                        // Set the answer
                        _questionTuples[questionId].Item3.Text = answer;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ResponseFunnel: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region Step Methods
        /// <summary>
        /// Helper method to increment to next step
        /// </summary>
        private void NextStep()
        {
            try
            {
                if (ValidateStep(_questionId))
                    ProcessStep(++_questionId);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"NextStep: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Helper method to decrement to the previous step
        /// </summary>
        private void PreviousStep()
        {
            try
            {
                ProcessStep(--_questionId);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"PreviousStep: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Sets the view up for the currently set step
        /// </summary>
        /// <param name="stepId"></param>
        private void ProcessStep(int step)
        {
            try
            {
                // Hide all questions
                foreach ((LinearLayout, TextView, TextView, List<View>) questionView in _questionTuples)
                    questionView.Item1.Visibility = ViewStates.Gone;

                // Show the current question
                if (step <= _questionTuples.Count)
                    _questionTuples[step].Item1.Visibility = ViewStates.Visible;

                // Handle buttons
                if (step <= 0)
                {
                    _dialogNegativeButton.SetText(Resource.String.text_cancel);
                    _dialogPositiveButton.SetText(Resource.String.text_next);
                    _dataConsentLabel.Visibility = ViewStates.Gone;
                }
                else if (step >= _questionTuples.Count - 1)
                {
                    _dialogNegativeButton.SetText(Resource.String.text_back);
                    _dialogPositiveButton.SetText(Resource.String.text_submit);
                    _dataConsentLabel.Visibility = ViewStates.Visible;
                }
                else
                {
                    _dialogNegativeButton.SetText(Resource.String.text_back);
                    _dialogPositiveButton.SetText(Resource.String.text_next);
                    _dataConsentLabel.Visibility = ViewStates.Gone;
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ProcessStep: {step}: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Validates the input step
        /// </summary>
        /// <param name="step"></param>
        /// <returns></returns>
        private bool ValidateStep(int step)
        {
            // Reset
            _problemLabel.Text = string.Empty;

            try
            {
                switch (step)
                {
                    case 0:
                    case 1:
                    case 2:
                        if (string.IsNullOrWhiteSpace(_questionTuples[step].Item3.Text))
                        {
                            _problemLabel.SetText(Resource.String.fragment_feedback_submission_error_no_option_selected);
                            return false;
                        }
                        break;
                    case 3:
                    case 4:
                    case 5:
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ValidateStep: {step}: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            return true;
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Displays the working progress indicator
        /// </summary>
        /// <param name="bIsWorking"></param>
        private void SetIsWorking(bool isWorking)
        {
            // Toggle views
            Library.Utilities.ViewUtils.SetViewAndChildrenEnabled(_rootLayout, !isWorking);

            // Report to parent
            if (this.Activity is IIndeterminateProgressReporter)
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
        }

        /// <summary>
        /// Submits all data to the squelch server
        /// </summary>
        private async void SubmitFeedback()
        {
            //
            // Vars
            string response;
            JObject parsedResponse;
            JToken resultCode;

            //
            // Start working animation, let the workflow stop it
            SetIsWorking(true);

            // Reset
            _problemLabel.Text = string.Empty;

            try
            {
                // 
                // Start web request
                response = await GeneralUtils.SendWebRequestAsync(GetString(Resource.String.link_squelch_website) + "/feedback/webservices/0.0.1/android.php", "POST", await BuildSubmitParameters());
                parsedResponse = JObject.Parse(response);
                if (parsedResponse.TryGetValue("result_code", out resultCode))
                {
                    if (resultCode.Value<string>() == "0") // Success
                    {
                        // Set user flags
                        UserSettings.SetFlagValue(UserSettings.FlagKeys.Feedback_Status, true.ToString());
                        UserSettings.SetFlagValue(UserSettings.FlagKeys.Feedback_StatusUpdatedOn, DateTime.Now.ToString());

                        // Set success
                        this.SetIsWorking(false);
                        DisplayUtils.ShowGenericAlertDialog(this.Context, GetString(Resource.String.text_success), GetString(Resource.String.fragment_feedback_submission_success), true, this.GetString(Resource.String.text_ok));

                        // Pop the backstack
                        this.FragmentManager.PopBackStack();
                    }
                    else if (resultCode.Value<string>() == "-2") // Duplicate
                    {
                        this.SetIsWorking(false);
                        DisplayUtils.ShowGenericAlertDialog(this.Context, GetString(Resource.String.text_duplicate), GetString(Resource.String.fragment_feedback_submission_duplicate), true, this.GetString(Resource.String.text_ok));
                        Logger.Write(_tag, $"SubmitFeedback: User has already submitted feedback... but can see this fragment?", Logger.Severity.Info);
                    }
                    else if (resultCode.Value<string>() == "-1") // Error
                    {
                        this.SetIsWorking(false);
                        DisplayUtils.ShowGenericAlertDialog(this.Context, GetString(Resource.String.text_error), GetString(Resource.String.fragment_feedback_submission_error_unexpected), true, this.GetString(Resource.String.text_ok));
                        Logger.Write(_tag, $"SubmitFeedback: An error was indicated by the server", Logger.Severity.Error);
                    }
                    else
                    {
                        this.SetIsWorking(false);
                        DisplayUtils.ShowGenericAlertDialog(this.Context, GetString(Resource.String.text_error), GetString(Resource.String.fragment_feedback_submission_error_unexpected), true, this.GetString(Resource.String.text_ok));
                        Logger.Write(_tag, $"SubmitFeedback: An unrecognized result code was received", Logger.Severity.Error);
                    }
                }
                else // Unable to parse response, something probably went wrong
                {
                    this.SetIsWorking(false);
                    DisplayUtils.ShowGenericAlertDialog(this.Context, GetString(Resource.String.text_error), GetString(Resource.String.fragment_feedback_submission_error_unexpected), true, this.GetString(Resource.String.text_ok));
                    Logger.Write(_tag, $"SubmitFeedback: An error occured when attempting to parse the http response", Logger.Severity.Error);
                }
            }
            catch (Exception ex)
            {
                this.SetIsWorking(false);
                DisplayUtils.ShowGenericAlertDialog(this.Context, GetString(Resource.String.text_error), GetString(Resource.String.fragment_feedback_submission_error_unexpected), true, this.GetString(Resource.String.text_ok));
                Logger.Write(_tag, $"SubmitFeedback: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Builds the data dictionary used for the submit web service request
        /// </summary>
        /// <returns></returns>
        private async Task<Dictionary<string, string>> BuildSubmitParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            List<object> questionResponses = new List<object>();

            try
            {
                //
                // Webservice specific
                parameters.Add("action", "submit");

                //
                // Squelch app info
                parameters.Add("squelch_version_name", (await GeneralUtils.SelfVersionNameAsync(this.Context)));
                parameters.Add("squelch_version_code", (await GeneralUtils.SelfVersionCodeAsync(this.Context)).ToString());

                //
                // Android info
                parameters.Add("android_release", (Build.VERSION.Release));
                parameters.Add("android_sdk", (Build.VERSION.SdkInt).ToString());

                //
                // Device info
                parameters.Add("device_brand", (Build.Brand));
                parameters.Add("device_manufacturer", (Build.Manufacturer));
                parameters.Add("device_model", (Build.Model));
                parameters.Add("device_product", (Build.Product));
                parameters.Add("device_name", (Build.Device));
                parameters.Add("device_host", (Build.Host));
                parameters.Add("device_display", (Build.Display));
                parameters.Add("device_id", (Build.Id));
                parameters.Add("device_abi", (((Build.VERSION.SdkInt < BuildVersionCodes.Lollipop) ? Build.CpuAbi : (Build.SupportedAbis.Count > 0 ? Build.SupportedAbis[0] : string.Empty))));

                //
                // Blackout info
                parameters.Add("user_blackouts", JsonConvert.SerializeObject((await BlackoutDatabase.FindAllAsync()).Take(10))); // Get the last 10 blackouts

                //
                // User info
                parameters.Add("user_info", JsonConvert.SerializeObject(UserSettings.UserItem));

                //
                // User feedback
                foreach ((LinearLayout, TextView, TextView, List<View>) questionTuple in _questionTuples)
                    questionResponses.Add(new { Question = questionTuple.Item2.Text, Response = questionTuple.Item3.Text });
                parameters.Add("user_feedback", JsonConvert.SerializeObject(questionResponses));
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"BuildSubmitParameters: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return parameters;
        }

        /// <summary>
        /// Confirms if the user wants to close prior to leaving the view
        /// </summary>
        private void ConfirmClose()
        {

            try
            {
                DisplayUtils.ShowGenericAlertDialog(this.Context, GetString(Resource.String.text_confirm), GetString(Resource.String.text_are_you_sure_cancel), true, GetString(Resource.String.text_yes), delegate { this.FragmentManager.PopBackStack(); }, GetString(Resource.String.text_cancel));
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ConfirmClose: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion
    }
}
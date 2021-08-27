# Squelch

## Todo / Enhancements
1. [Feature] Add recurring schedules (perhaps use crontab?).
2. [Feature] Add additional modes into the blackout process, such as VPN mode.
3. [Feature] Add pre-set app list(s) that users can define for the blackout setup process.
4. [Feature] Add quick blackout options to home fragment (quick 30 mins, full lockouts, etc).
5. [Improvement] Modify how the quick options work for date selection on the BlackoutSetupFragment. It can be confusing for the user to select "NOW" and by the time they are done setting it up, time has already passed.
6. [Feature] Add trash talk option to overlay (user configurable).
7. [Improvement] Add a job scheduler that checks to see if the EnforcerService is running, and if not, start it back up.

## Existing Gotchas:
* The BlackoutSetupFragment, FirstTimeSetupFragment, and the FeedbackFragment all use the text on their respective positive/negative buttons to indicate when it should complete its process. If the words "Next" and "Finish" ever translate to the same thing, this will cause a bug.

## Changelog:
* Added time format user setting.
* Added DateUtils class for formatting datetimes using Android's built in DateUtil and SimpleDateFormatter.
* Updated all text sources to use localized strings instead of hardcoded strings.
* Updated in app billing plugin to v4.
* Added translations for Hindi
* Modified how the BlackoutSetupFragment handles the start date and end date assignments.
* Added Firebase Crashlytics sdk
* Added Firebase Performance sdk
* Added scrolling to the backout details dialog.

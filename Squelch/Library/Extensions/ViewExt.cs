using Android.Widget;

namespace Squelch.Library.Extensions
{
    internal static class ViewExt
    {
        /// <summary>
        /// Sets the text of a button but converting the provide string to a character array and applying it
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static void SetButtonText(this Button button, string text)
        {
            char[] result = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
                result[i] = text[i];

            button.SetText(result, 0, result.Length);
        }
    }
}
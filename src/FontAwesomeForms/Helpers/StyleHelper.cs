using System;
using Xamarin.Forms;

namespace FontAwesomeForms.Helpers
{
    public class StyleHelper
    {
        public static void SetStyle(View element, string styleKey)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            var resources = Application.Current.Resources;

            if (!resources.ContainsKey(styleKey))
                return;

            var style = resources[styleKey] as Style;

            if (style == null)
                return;

            element.Style = style;
        }

        public static void SetStyle(Page element, string styleKey)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            var resources = Application.Current.Resources;

            if (!resources.ContainsKey(styleKey))
                return;

            var style = resources[styleKey] as Style;

            if (style == null)
                return;

            element.Style = style;
        }
    }
}

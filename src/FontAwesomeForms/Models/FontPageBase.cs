using System;
using Xamarin.Forms;

namespace FontAwesomeForms.Models
{
    public abstract class FontPageBase : ContentPage, IFontPage
    {
        public string Glyph { get; set; }

        public string FontFamily { get; set; }
    }
}

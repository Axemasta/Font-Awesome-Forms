using System;
using System.Collections.ObjectModel;
using FontAwesomeForms.Extensions;
using FontAwesomeForms.Models;

namespace FontAwesomeForms.ViewModels
{
    public class ProFontsViewModel : ViewModelBase, IFontViewModel
    {
        public ObservableCollection<FontInformation> Fonts { get; }

        public string Glyph1 { get; } = FontAwesome.FontAwesomeIcons.Ufo;

        public string Glyph2 { get; } = FontAwesome.FontAwesomeIcons.PortalExit;

        public string FontFamily { get; } = FontConstants.FontAwesomePro.Light;

        public ProFontsViewModel()
        {
            Title = "Pro";

            var fonts = FontInformation.FontAwesomePro();

            Fonts = fonts.ToObservableCollection();
        }
    }
}

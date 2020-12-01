using System;
using System.Collections.ObjectModel;
using FontAwesomeForms.Extensions;
using FontAwesomeForms.Models;

namespace FontAwesomeForms.ViewModels
{
    public class ProFontsViewModel : ViewModelBase, IFontViewModel
    {
        public ObservableCollection<FontInformation> Fonts { get; }

        public string Glyph1 { get; } = "\uf2db";

        public string Glyph2 { get; } = "\ue048";

        public string FontFamily { get; } = FontConstants.FontAwesomePro.Light;

        public ProFontsViewModel()
        {
            Title = "Pro";

            var fonts = FontInformation.FontAwesomePro();

            Fonts = fonts.ToObservableCollection();
        }
    }
}

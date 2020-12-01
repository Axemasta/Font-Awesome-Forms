using System;
using System.Collections.ObjectModel;
using FontAwesomeForms.Extensions;
using FontAwesomeForms.Models;

namespace FontAwesomeForms.ViewModels
{
    public class FreeFontsViewModel : ViewModelBase, IFontViewModel
    {
        public ObservableCollection<FontInformation> Fonts { get; }

        public string Glyph1 { get; } = "\uf53a";

        public string Glyph2 { get; } = "\uf51e";

        public string FontFamily { get; } = FontConstants.FontAwesomeFree.Solid;

        public FreeFontsViewModel()
        {
            Title = "Free";

            var fonts = FontInformation.FontAwesomeFree();

            Fonts = fonts.ToObservableCollection();
        }
    }
}

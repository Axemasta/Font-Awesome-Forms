using System;
using System.Collections.ObjectModel;
using FontAwesomeForms.Extensions;
using FontAwesomeForms.Models;

namespace FontAwesomeForms.ViewModels
{
    public class FreeFontsViewModel : ViewModelBase, IFontViewModel
    {
        public ObservableCollection<FontInformation> Fonts { get; }

        public string Glyph1 { get; } = FontAwesome.FontAwesomeIcons.Atom;

        public string Glyph2 { get; } = FontAwesome.FontAwesomeIcons.Splotch;

        public string FontFamily { get; } = FontConstants.FontAwesomeFree.Solid;

        public FreeFontsViewModel()
        {
            Title = "Free";

            var fonts = FontInformation.FontAwesomeFree();

            Fonts = fonts.ToObservableCollection();
        }
    }
}

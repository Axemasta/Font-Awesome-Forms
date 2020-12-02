using System;
using System.Collections.ObjectModel;

namespace FontAwesomeForms.Models
{
    public interface IFontViewModel
    {
        ObservableCollection<FontInformation> Fonts { get; }

        string Glyph1 { get; }

        string Glyph2 { get; }

        string FontFamily { get; }
    }
}

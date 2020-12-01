using System;
using System.Collections.ObjectModel;
using FontAwesomeForms.Extensions;
using FontAwesomeForms.Models;

namespace FontAwesomeForms.ViewModels
{
    public class ProFontsViewModel : ViewModelBase
    {
        public ObservableCollection<FontInformation> Fonts { get; }

        public ProFontsViewModel()
        {
            Title = "Pro";

            var fonts = FontInformation.FontAwesomePro();

            Fonts = fonts.ToObservableCollection();
        }
    }
}

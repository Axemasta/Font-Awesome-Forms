using System;
using System.Collections.ObjectModel;
using FontAwesomeForms.Extensions;
using FontAwesomeForms.Models;

namespace FontAwesomeForms.ViewModels
{
    public class FreeFontsViewModel : ViewModelBase
    {
        public ObservableCollection<FontInformation> Fonts { get; }

        public FreeFontsViewModel()
        {
            Title = "Free";

            var fonts = FontInformation.FontAwesomeFree();

            Fonts = fonts.ToObservableCollection();
        }
    }
}

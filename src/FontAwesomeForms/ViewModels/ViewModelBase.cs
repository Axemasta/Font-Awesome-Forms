using System;
using FontAwesomeForms.ViewModels.Mvvm;

namespace FontAwesomeForms.ViewModels
{
    public abstract class ViewModelBase : BindableBase
    {
        public string Title { get; set; }
    }
}

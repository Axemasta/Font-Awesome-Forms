using System;
using FontAwesomeForms.Models;
using FontAwesomeForms.ViewModels;
using Xamarin.Forms;

namespace FontAwesomeForms.Pages
{
    public class FreeCodePage : FontPageBase
    {
        readonly CodePageViewModel viewModel;

        public FreeCodePage()
        {
            base.Glyph = "\uf121";
            base.FontFamily = FontConstants.FontAwesomeFree.Solid;

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };

            viewModel = new CodePageViewModel();
            base.BindingContext = viewModel;

            
            Title = viewModel.Title;
        }

        
    }
}


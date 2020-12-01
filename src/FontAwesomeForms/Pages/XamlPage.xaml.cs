using System;
using System.Collections.Generic;
using FontAwesomeForms.Models;
using FontAwesomeForms.ViewModels;
using Xamarin.Forms;

namespace FontAwesomeForms.Pages
{
    public partial class XamlPage : FontPageBase
    {
        public XamlPage(object viewModel)
        {
            InitializeComponent();

            base.Glyph = "\uf542";
            base.FontFamily = FontConstants.FontAwesomeFree.Solid;

            base.BindingContext = viewModel;
        }
    }
}

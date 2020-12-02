using System;
using System.Collections.Generic;
using FontAwesomeForms.Models;
using Xamarin.Forms;

namespace FontAwesomeForms.Pages
{
    public partial class MiscPage : FontPageBase
    {
        public MiscPage()
        {
            InitializeComponent();

            base.Glyph = "\uf129";
            base.FontFamily = FontConstants.FontAwesomeFree.Solid;
        }
    }
}

using System;
using System.Collections.Generic;
using FontAwesomeForms.Models;
using FontAwesomeForms.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FontAwesomeForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            


            MainPage = BuildRootView();
        }


        Page BuildRootView()
        {
            var barBackgroundColor = Color.FromHex("#2196F3");

            var tabbed = new TabbedPage()
            {
                BarBackgroundColor = barBackgroundColor,
                BarTextColor = Color.White,
                UnselectedTabColor = Color.FromHex("#184d79"),
                SelectedTabColor = Color.White,
            };

            var xaml = new FreeXamlPage();
            var code = new FreeCodePage();

            var pages = new List<FontPageBase>
            {
                xaml,
                code
            };

            foreach (var page in pages)
            {
                var nav = new NavigationPage(page)
                {
                    BarBackgroundColor = barBackgroundColor,
                    Title = page.Title,
                    IconImageSource = new FontImageSource()
                    {
                        Glyph = page.Glyph,
                        FontFamily = page.FontFamily,
                        Size = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
                    }
                };

                tabbed.Children.Add(nav);
            }

            return tabbed;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

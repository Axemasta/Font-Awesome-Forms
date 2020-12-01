﻿using System;
using System.Collections.Generic;
using FontAwesomeForms.Models;
using FontAwesomeForms.Pages;
using FontAwesomeForms.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
//using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace FontAwesomeForms
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = BuildRootView();
        }


        Page BuildRootView()
        {
            var barBackgroundColor = Color.FromHex("#2196F3");

            var tabbed = new Xamarin.Forms.TabbedPage()
            {
                BarBackgroundColor = barBackgroundColor,
                BarTextColor = Color.White,
                UnselectedTabColor = Color.FromHex("#184d79"),
                SelectedTabColor = Color.White,
            };

            //Free
            var freeViewModel = new FreeFontsViewModel();
            
            var xamlFree = new XamlPage(freeViewModel);
            var codeFree = new CodePage(freeViewModel);

            var pages = new List<FontPageBase>
            {
                xamlFree,
                codeFree
            };

            //Pro - Uncomment if you installed pro fonts :)
            var proViewModel = new ProFontsViewModel();

            var xamlPro = new XamlPage(proViewModel);
            var codePro = new CodePage(proViewModel);

            pages.Add(xamlPro);
            pages.Add(codePro);

            pages.Add(new MiscPage());

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
                        Size = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Button))
                    }
                };

                tabbed.Children.Add(nav);
            }

            tabbed.On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

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

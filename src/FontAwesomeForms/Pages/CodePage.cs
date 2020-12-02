using System;
using System.Collections.Generic;
using FontAwesomeForms.Controls;
using FontAwesomeForms.Helpers;
using FontAwesomeForms.Models;
using FontAwesomeForms.ViewModels;
using Xamarin.Forms;

namespace FontAwesomeForms.Pages
{
    public class CodePage : FontPageBase
    {
        public CodePage(object viewModel)
        {
            base.Glyph = FontAwesome.FontAwesomeIcons.Code;
            base.FontFamily = FontConstants.FontAwesomeFree.Solid;

            this.Padding = new Thickness(10);

            
            Content = BuildView();

            StyleHelper.SetStyle(this, "contentPageDefault");
            
            base.BindingContext = viewModel;

            this.SetBinding(TitleProperty, "Title", stringFormat: "Code {0}");

            SetTitleView();
        }

        View BuildView()
        {
            var collectionView = new CollectionView();
            collectionView.SetBinding(ItemsView.ItemsSourceProperty, "Fonts");

            switch (Device.Idiom)
            {
                default:
                case TargetIdiom.Phone:
                    collectionView.ItemsLayout = new GridItemsLayout(ItemsLayoutOrientation.Vertical) { Span = 1 };
                    break;

                case TargetIdiom.Tablet:
                    collectionView.ItemsLayout = new GridItemsLayout(ItemsLayoutOrientation.Vertical) { Span = 2 };
                    break;
            }

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                var panel = new ShowcasePanel()
                {
                    Padding = new Thickness(10)
                };

                panel.SetBinding(ShowcasePanel.FontInformationProperty, ".");

                StyleHelper.SetStyle(panel, "showcasePanel");

                return panel;
            });

            return collectionView;
        }

        void SetTitleView()
        {
            var titleView = new GlyphTitleView();

            titleView.SetBinding(GlyphTitleView.TitleProperty, "Title", stringFormat: "Code {0}");
            titleView.SetBinding(GlyphTitleView.Glyph1Property, "Glyph1");
            titleView.SetBinding(GlyphTitleView.Glyph2Property, "Glyph2");
            titleView.SetBinding(GlyphTitleView.FontFamilyProperty, "FontFamily");

            StyleHelper.SetStyle(titleView, "glyphTitle");

            NavigationPage.SetTitleView(this, titleView);
        }
    }
}


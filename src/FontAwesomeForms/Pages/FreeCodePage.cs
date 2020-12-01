using System;
using System.Collections.Generic;
using FontAwesomeForms.Controls;
using FontAwesomeForms.Models;
using FontAwesomeForms.ViewModels;
using Xamarin.Forms;

namespace FontAwesomeForms.Pages
{
    public class FreeCodePage : FontPageBase
    {
        readonly FreeFontsViewModel viewModel;

        public FreeCodePage()
        {
            base.Glyph = "\uf121";
            base.FontFamily = FontConstants.FontAwesomeFree.Solid;

            Content = BuildView();

            viewModel = new FreeFontsViewModel();
            base.BindingContext = viewModel;

            Title = string.Format("Code {0}", viewModel.Title);
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

                return panel;
            });

            return collectionView;
        }
    }
}


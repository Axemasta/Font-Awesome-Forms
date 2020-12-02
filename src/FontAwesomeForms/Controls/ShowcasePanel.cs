using System;
using FontAwesomeForms.Models;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace FontAwesomeForms.Controls
{
    public class ShowcasePanel : ContentView
    {
        public static readonly BindableProperty FontInformationProperty = BindableProperty.Create(nameof(FontInformation), typeof(FontInformation), typeof(ShowcasePanel), propertyChanged: OnValuePropertyChanged);

        public static readonly BindableProperty PanelBackgroundColorProperty = BindableProperty.Create(nameof(PanelBackgroundColor), typeof(Color), typeof(ShowcasePanel), propertyChanged: OnValuePropertyChanged);

        public static readonly BindableProperty PanelShadowProperty = BindableProperty.Create(nameof(PanelShadow), typeof(DropShadow), typeof(ShowcasePanel), propertyChanged: OnValuePropertyChanged);

        public FontInformation FontInformation
        {
            get => (FontInformation)GetValue(FontInformationProperty);
            set => SetValue(FontInformationProperty, value);
        }

        public Color PanelBackgroundColor
        {
            get => (Color)GetValue(PanelBackgroundColorProperty);
            set => SetValue(PanelBackgroundColorProperty, value);
        }

        public DropShadow PanelShadow
        {
            get => (DropShadow)GetValue(PanelShadowProperty);
            set => SetValue(PanelShadowProperty, value);
        }

        static void OnValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
            => ((ShowcasePanel)bindable).OnValuePropertyChanged();

        Grid contentGrid { get; } = new Grid()
        {
            Padding = new Thickness(20),
            RowDefinitions = new RowDefinitionCollection()
            {
                new RowDefinition() { Height = GridLength.Auto },
                new RowDefinition() { Height = GridLength.Auto }
            }
        };

        PancakeView contentPancake { get; } = new PancakeView()
        {
            CornerRadius = 20,
            BackgroundColor = Color.Default,
            Shadow = new DropShadow()
            {
                Color = Color.FromHex("#333d47"),
                Opacity = 0.1f
            }
        };

        Label displayLabel { get; } = new Label()
        {
            Text = "init",
            FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            FontAttributes = FontAttributes.Italic,
            HorizontalTextAlignment = TextAlignment.Center
        };

        Grid iconGrid { get; } = new Grid()
        {
            ColumnSpacing = 20,
            RowSpacing = 20,
            Margin = new Thickness(20),
            RowDefinitions = new RowDefinitionCollection()
                {
                    new RowDefinition() { Height = GridLength.Star },
                    new RowDefinition() { Height = GridLength.Star }
                },
            ColumnDefinitions = new ColumnDefinitionCollection()
                {
                    new ColumnDefinition() { Width = GridLength.Star },
                    new ColumnDefinition() { Width = GridLength.Star }
                }
        };

        static Style iconLabelStyle { get; } = new Style(typeof(Label))
        {
            Setters =
            {
                new Setter() { Property = Label.FontSizeProperty, Value = 32 },
                new Setter() { Property = VerticalOptionsProperty, Value = LayoutOptions.Center },
                new Setter() { Property = HorizontalOptionsProperty, Value = LayoutOptions.Center }
            }
        };

        Label icon1 { get; } = new Label()
        {
            Style = iconLabelStyle,
        };

        Label icon2 { get; } = new Label()
        {
            Style = iconLabelStyle,
        };

        Label icon3 { get; } = new Label()
        {
            Style = iconLabelStyle,
        };

        Label icon4 { get; } = new Label()
        {
            Style = iconLabelStyle,
        };

        public ShowcasePanel()
        {
            this.Content = BuildView();
        }

        View BuildView()
        {
            

            Grid.SetRow(icon1, 0);
            Grid.SetRow(icon2, 0);
            Grid.SetRow(icon3, 1);
            Grid.SetRow(icon4, 1);

            Grid.SetColumn(icon1, 0);
            Grid.SetColumn(icon2, 1);
            Grid.SetColumn(icon3, 0);
            Grid.SetColumn(icon4, 1);

            iconGrid.Children.Add(icon1);
            iconGrid.Children.Add(icon2);
            iconGrid.Children.Add(icon3);
            iconGrid.Children.Add(icon4);

            Grid.SetRow(displayLabel, 0);
            Grid.SetRow(iconGrid, 1);

            contentGrid.Children.Add(displayLabel);
            contentGrid.Children.Add(iconGrid);

            contentPancake.Content = contentGrid;

            return contentPancake;
        }

        void OnValuePropertyChanged()
        {
            if (FontInformation != null)
            {
                displayLabel.Text = FontInformation.FontDisplayName;

                icon1.FontFamily = FontInformation.FontName;
                icon2.FontFamily = FontInformation.FontName;
                icon3.FontFamily = FontInformation.FontName;
                icon4.FontFamily = FontInformation.FontName;

                icon1.Text = FontInformation.Icon1;
                icon2.Text = FontInformation.Icon2;
                icon3.Text = FontInformation.Icon3;
                icon4.Text = FontInformation.Icon4;
            }

            contentPancake.BackgroundColor = PanelBackgroundColor;
            contentPancake.Shadow = PanelShadow;
        }
    }
}

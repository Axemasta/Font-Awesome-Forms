using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace FontAwesomeForms.Controls
{
    public class GlyphTitleView : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(GlyphTitleView), propertyChanged: OnValuePropertyChanged);

        public static readonly BindableProperty Glyph1Property = BindableProperty.Create(nameof(Glyph1), typeof(string), typeof(GlyphTitleView), propertyChanged: OnValuePropertyChanged);

        public static readonly BindableProperty Glyph2Property = BindableProperty.Create(nameof(Glyph2), typeof(string), typeof(GlyphTitleView), propertyChanged: OnValuePropertyChanged);

        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(GlyphTitleView), propertyChanged: (bindable, oldVal, newVal) => ((GlyphTitleView)bindable).OnFontFamilyChanged((string)newVal));

        public static readonly BindableProperty TitleColorProperty = BindableProperty.Create(nameof(TitleColor), typeof(Color), typeof(GlyphTitleView), Color.Default, propertyChanged: OnValuePropertyChanged);

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public string Glyph1
        {
            get => (string)GetValue(Glyph1Property);
            set => SetValue(Glyph1Property, value);
        }

        public string Glyph2
        {
            get => (string)GetValue(Glyph2Property);
            set => SetValue(Glyph2Property, value);
        }

        public string FontFamily
        {
            get => (string)GetValue(FontFamilyProperty);
            set => SetValue(FontFamilyProperty, value);
        }

        public Color TitleColor
        {
            get => (Color)GetValue(TitleColorProperty);
            set => SetValue(TitleColorProperty, value);
        }

        static void OnValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
            => ((GlyphTitleView)bindable).OnValuePropertyChanged();

        Grid titleGrid { get; } = new Grid
        {
            VerticalOptions = LayoutOptions.Fill,
            HorizontalOptions = LayoutOptions.Fill,
            ColumnDefinitions = new ColumnDefinitionCollection()
            {
                new ColumnDefinition() { Width = GridLength.Star },
                new ColumnDefinition() { Width = GridLength.Auto },
                new ColumnDefinition() { Width = GridLength.Star }
            }
        };

        Label titleLabel { get; } = new Label
        {
            FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
            VerticalOptions = LayoutOptions.Center,
            VerticalTextAlignment = TextAlignment.Center,
            FormattedText = new FormattedString()
            {
                Spans =
                {
                    new Span() { Text = "" },
                    new Span() { Text = "" },
                    new Span() { Text = "" }
                }
            }
        };

        public GlyphTitleView()
        {
            this.Content = BuildTitleView();
        }

        View BuildTitleView()
        {
            Grid.SetColumn(titleLabel, 1);

            titleGrid.Children.Add(titleLabel);

            return titleGrid;
        }

        void OnValuePropertyChanged()
        {
            if (!string.IsNullOrEmpty(Glyph1) && titleLabel.FormattedText.Spans.ElementAtOrDefault(0) != null)
            {
                titleLabel.FormattedText.Spans[0].Text = Glyph1;
            }

            titleLabel.FormattedText.Spans[1].Text = " " + Title + " ";

            if (!string.IsNullOrEmpty(Glyph2) && titleLabel.FormattedText.Spans.ElementAtOrDefault(2) != null)
            {
                titleLabel.FormattedText.Spans[2].Text = Glyph2;
            }

            titleLabel.TextColor = TitleColor;
        }

        void OnFontFamilyChanged(string fontFamily)
        {
            if (titleLabel.FormattedText.Spans.ElementAtOrDefault(0) != null)
            {
                titleLabel.FormattedText.Spans[0].FontFamily = fontFamily;
            }

            if (titleLabel.FormattedText.Spans.ElementAtOrDefault(2) != null)
            {
                titleLabel.FormattedText.Spans[2].FontFamily = fontFamily;
            }
        }
    }
}

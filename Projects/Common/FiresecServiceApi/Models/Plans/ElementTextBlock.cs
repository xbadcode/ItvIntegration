﻿using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FiresecAPI.Models
{
    [DataContract]
    public class ElementTextBlock : ElementBase, IZIndexedElement
    {
        public ElementTextBlock()
        {
            Text = "Text";
            ForegroundColor = Colors.Black;
        }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public Color BackgroundColor { get; set; }

        [DataMember]
        public Color ForegroundColor { get; set; }

        [DataMember]
        public Color BorderColor { get; set; }

        [DataMember]
        public double BorderThickness { get; set; }

        [DataMember]
        public double FontSize { get; set; }

        [DataMember]
        public int ZIndex { get; set; }

        public override FrameworkElement Draw()
        {
            var textBlock = new Label()
            {
                Content = Text,
                Background = new SolidColorBrush(BackgroundColor),
                Foreground = new SolidColorBrush(ForegroundColor),
                BorderBrush = new SolidColorBrush(BorderColor),
                BorderThickness = new Thickness(BorderThickness)
            };
            return textBlock;
        }

        public override ElementBase Clone()
        {
            ElementBase elementBase = new ElementTextBlock()
            {
                Text = Text,
                BackgroundColor = BackgroundColor,
                ForegroundColor = ForegroundColor,
                BorderColor = BorderColor,
                BorderThickness = BorderThickness,
                FontSize = FontSize
            };
            Copy(elementBase);
            return elementBase;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace CxControlLibrary
{
    public class CxComboBoxItem:ComboBoxItem
    {
        public CxComboBoxItem():base()
        {
            Height = 30;
            Width = 315;
            Margin = new System.Windows.Thickness(-4, 0, 0, 0);
        }
        public CxComboBoxItem(object content) : base()
        {
            Height = 30;
            Width = 315;
            Margin = new System.Windows.Thickness(-4, 0, 0, 0);
            this.Content = content;
        }
        public string Label
        {
            get
            {
                return (this.Content)as string;
            }
            set
            {
                this.Content = (value as string);
            }
        }
        public bool Enabled
        {
            get
            {
                return IsEnabled;
            }
            set
            {
                IsEnabled = value;
            }
        }
        public FontFamily Font
        {
            get
            {
                return FontFamily;
            }
            set
            {
                FontFamily = value;
            }
        }
        public Brush Color
        {
            get
            {
                return Foreground;
            }
            set
            {
                Foreground = value;
            }
        }
        public Brush BackColor
        {
            get
            {
                return Background;
            }
            set
            {
                Background = value;
            }
        }
        public DropShadowBitmapEffect DropShadow
        {
            get
            {
                return this.DropShadow;
            }
            set
            {
                this.DropShadow = value;
            }
        }
        public override string ToString()
        {
            return this.Content as String;
        }
    }
}

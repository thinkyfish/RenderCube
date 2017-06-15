﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urho.Gui;
using Urho;

namespace RenderCube
{
    class ControlBar : UIElement
    {
        private Button prevButton = new Button();
        private Text Label = new Text();
        public ControlBar(string title)
        {
            this.SetMinSize(0, 24);
            this.VerticalAlignment = VerticalAlignment.Top;
            this.LayoutMode = LayoutMode.Horizontal;

            
            
            prevButton.Released += this.OnPrevious;
            prevButton.SetFixedSize(24, 24);
            this.AddChild(prevButton);

            
            Label.TextAlignment = HorizontalAlignment.Center;

            Label.Value = title;
            this.AddChild(Label);
            this.SetStyleAuto(null);
            Label.SetStyleAuto(null);
            prevButton.SetStyleAuto(null);
            //prevButton.SetStyle("LeftButton", null);
        }
        public Action OnNext;
        public Action<ReleasedEventArgs> OnPrevious;
        //public new bool SetStyleAuto(Urho.Resources.XmlFile file)
        //{
        //    bool ret = base.SetStyleAuto(file);
        //    Label.SetStyleAuto(file);
        //    prevButton.SetStyle("LeftButton", file);

            
        //    return ret;
        //}
    }
}
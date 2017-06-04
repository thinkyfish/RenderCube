﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urho.Gui;
using Urho;
namespace RenderCube
{
    class MaterialPanel : Panel
    {
        RangeSlider IORSlider;
        RangeSlider TestSlider;
        Material material;

        public MaterialPanel( UIElement parent, Material m) : base()
        {
            material = m;

            parent.AddChild(this);
            this.SetStyleAuto(null);

            this.SetMinSize(600, 200);
            this.SetLayout(LayoutMode.Vertical, 6, new IntRect(6, 6, 6, 6));
            this.SetAlignment(HorizontalAlignment.Center, VerticalAlignment.Bottom);
            this.Name = "MaterialPanel";
            //// Create Window 'titlebar' container
            //UIElement titleBar = new UIElement();
            //titleBar.SetMinSize(0, 24);
            //titleBar.VerticalAlignment = VerticalAlignment.Top;
            //titleBar.LayoutMode = LayoutMode.Horizontal;

            //// Create the Window title Text
            //var windowTitle = new Text();
            //windowTitle.Name = "WindowTitle";
            //windowTitle.Value = "Hello GUI!";

            //// Create the Window's close button
            //Button buttonClose = new Button();
            //buttonClose.Name = "CloseButton";

            //// Add the controls to the title bar
            //titleBar.AddChild(windowTitle);
            //titleBar.AddChild(buttonClose);

            //this.AddChild(titleBar);
            //windowTitle.SetStyleAuto(null);
            //buttonClose.SetStyle("CloseButton", null);

            //buttonClose.SubscribeToReleased(_ => Exit());

            IORSlider = this.CreateSlider("Ior Ratio", 0.0f, 1.0f);
            IORSlider.SliderChanged +=
                (args => material.SetShaderParameter("RefractIndex", args.Value));
            IORSlider.Value = 0.666f;
            //TestSlider = this.CreateSlider(0, 20, 100, 20, "TEST", (args => { }));
 
            //IORSlider.SetStyleAuto(this.GetDefaultStyle(true));
            
            //this.SetStyleAuto(null);
        }
        public void SetIORValue(float value)
        {
            IORSlider.Value = value;
        }

    }
}
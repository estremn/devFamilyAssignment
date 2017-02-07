using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace elloXamarin
{
    public class elloXamarin : ContentPage
    {
        public elloXamarin()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Ello Xamarin" }
                }
            };
        }
    }
}

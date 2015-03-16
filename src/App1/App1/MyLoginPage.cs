using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class MyLoginPage : ContentPage
    {
        public MyLoginPage()
        {
            var label1 = new Label
            {
                Text = "Hello Ios",
                BackgroundColor = Color.Green,
                WidthRequest = 100,
                HeightRequest = 100
            };

            var label2 = new Label
            {
                Text = "Hello Android",
                BackgroundColor = Color.Red,
                WidthRequest = 100,
                HeightRequest = 100
            };
            var layout = new AbsoluteLayout();
            layout.Children.Add(label1, new Point(20, 20));
            layout.Children.Add(label2, new Point(100, 100));

            Padding = new Thickness(20);
            Content = layout;
        }
    }
}

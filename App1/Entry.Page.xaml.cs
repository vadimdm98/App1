using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entry : ContentPage
    {
        Editor ed;
        public Entry()
        {
            ed = new Editor
            {
                Placeholder = "Sisesta siia tekst",
                BackgroundColor = Color.Violet,
                TextColor = Color.Plum
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { ed },
                BackgroundColor = Color.Pink
            };
            Content = st;
                

        }
    }
}
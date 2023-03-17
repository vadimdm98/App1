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
    public partial class startPage1 : ContentPage
    {
        List<Page> pages = new List<Page>() { new Entry(), new Timer_Page(), new BoxViev_Pages(), new Valgusfoor() ,new Snegovik_Page(), new Frame_Page()};
        
        List<string> tekstid = new List<string> { "Ava tekst leht", "Ava timer leht", "Ava box leht", "Ava valgusfoor leht", "Ava snegovik leht", "Ava frame leht" };
        public startPage1()
        
       {
            StackLayout st = new StackLayout

            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Yellow
            };

            for (int i = 0;i < pages.Count; i++)
            {

                Button button = new Button
                {
                    Text = tekstid[i],
                    TabIndex = i,
                    BackgroundColor = Color.Violet,
                    TextColor = Color.Tomato,


                };
                st.Children.Add(button);
                button.Clicked += Navig_funktsion;
            }
            //InitializeComponent();
            //Button Entry_btn = new Button
            //{
            //    Text = "Ava Entry leht",
            //    TextColor = Color.Tomato,
            //    BackgroundColor = Color.Violet,
            //    TabIndex = 0
            //};
            //Button Timer_btn = new Button
            //{
            //    Text = "Ava Timer leht",
            //    TextColor = Color.Tomato,
            //    BackgroundColor = Color.Violet,
            //    TabIndex = 1
            //};
            //Button Box_btn = new Button
            //{
            //    Text = "Ava Timer leht",
            //    TextColor = Color.Tomato,
            //    BackgroundColor = Color.Violet,
            //    TabIndex = 2
            //};
            //Button Valgusfoor_btn = new Button
            //{
            //    Text = "Ava Valgusfoor leht",
            //    TextColor = Color.Tomato,
            //    BackgroundColor = Color.Violet,
            //    TabIndex = 3
            //};
            
            Content = st;
            //Entry_btn.Clicked += Navig_funktsion;
            //Timer_btn.Clicked += Navig_funktsion;
            //Box_btn.Clicked += Navig_funktsion;


        }

        private async void Navig_funktsion (object sender, EventArgs e)
        {
            Button btn=sender as Button;
            await Navigation.PushAsync(pages[btn.TabIndex]);
        }


    }
        
        


    
         
       
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppEvaluacion3WEB1._3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BackgroundImageSource = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/wallpapers/wllppr" + new Random().Next(9) + ".jpg";
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            try
            {
                //BackgroundImageSource = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/wallpapers/wllppr" + new Random().Next(9) + ".jpg";
                await Navigation.PushAsync(new ActivityList());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

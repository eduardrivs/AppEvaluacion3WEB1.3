using AppEvaluacion3WEB1._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEvaluacion3WEB1._3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityDetailsList : ContentPage
    {
        public IList<Album> Albums { get; private set; }
        public ActivityDetailsList(Artist artist)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
            Albums = artist.Discografia;
            BindingContext = this;

            imgArtist.Source = artist.ImagenURL;
            lblArtistName.Text = artist.Nombre;
            lblDescipcion.Text = artist.Descripcion;
        }

        async void OnSelectionChanged(Object sender, SelectionChangedEventArgs e)
        {
            Album selectedItem = e.CurrentSelection[0] as Album;
            if (selectedItem == null)
                return;
            await DisplayAlert("Nombre del album", selectedItem.Nombre+"\nPor discográfica: "+selectedItem.Discografica, "Siguiente");
            await DisplayActionSheet("Canciones del Album", "A orale va", null,
                selectedItem.Canciones[0].Duracion + "\t- "+selectedItem.Canciones[0].Nombre,
                selectedItem.Canciones[1].Duracion + "\t- " + selectedItem.Canciones[1].Nombre,
                selectedItem.Canciones[2].Duracion + "\t- " + selectedItem.Canciones[2].Nombre);
        }

        private async void activityFormPush()
        {
            await Navigation.PushAsync(new ActivityForm());
        }

        private void btnFloating_Clicked(object sender, EventArgs e)
        {
            activityFormPush();
        }
    }
}
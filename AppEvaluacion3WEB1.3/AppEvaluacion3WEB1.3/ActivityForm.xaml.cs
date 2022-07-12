using AppEvaluacion3WEB1._3.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEvaluacion3WEB1._3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityForm : ContentPage
    {
        public ActivityForm()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void pickerEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerEstados.SelectedIndex != -1)
            {
                switch (pickerEstados.SelectedIndex)
                {
                    case 0:
                        pickerMunicipios.ItemsSource = new List<string> {
                            "Jilotepec","Acambay","Huehuetoca","Metepec"
                        };
                        break;
                    case 1:
                        pickerMunicipios.ItemsSource = new List<string> {
                            "Tula","Tepeji","Pachuca","Actopan"
                        };
                        break;
                    case 2:
                        pickerMunicipios.ItemsSource = new List<string> {
                            "Cuauhtémoc","Coyoacán","Álvaro Obregón","Azcapotzalco"
                        };
                        break;
                }
            }
        }

        private async void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtaPaterno.Text) ||
                String.IsNullOrEmpty(txtAMaterno.Text) || String.IsNullOrEmpty(txtTelefono.Text) ||
                String.IsNullOrEmpty(txtColonia.Text) || String.IsNullOrEmpty(txtDireccion.Text))
            {
                await DisplayAlert("Alerta", "Los campos no deben estar vacios", "Ok");
                return;
            }

            try
            {
                PersonaVM persona = new PersonaVM
                {
                    Nombre = txtNombre.Text,
                    APaterno = txtaPaterno.Text,
                    AMaterno = txtAMaterno.Text,
                    Telefono = txtTelefono.Text,
                    IdEstado = GetIdDireccion(pickerEstados.SelectedItem.ToString()),
                    IdMunicipio = GetIdDireccion(pickerMunicipios.SelectedItem.ToString()),
                    Colonia = txtColonia.Text,
                    Direccion = txtDireccion.Text
                };

                Uri RequestUri = new Uri("https://xamarinapi.somee.com/api/persona/save");

                var client = new HttpClient();
                var json = JsonConvert.SerializeObject(persona);
                var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(RequestUri, contentJson);
                if (response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Informacion", "Se ha registrado correctamente el usuario", "Ok");
                    txtNombre.Text = "";
                    txtaPaterno.Text = "";
                    txtAMaterno.Text = "";
                    txtTelefono.Text = "";
                    //pickerEstados.SelectedIndex = -1;
                    //pickerMunicipios.SelectedIndex = -1;
                    txtColonia.Text = "";
                    txtDireccion.Text = "";
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                await DisplayAlert("Informacion", "Ocurrio un error al intentar registrar el usuario", "Ok");
            }
        }

        private int GetIdDireccion(string text)
        {
            switch (text)
            {
                // Estado de Mexico
                case "Estado de México":
                    return 14;
                case "Jilotepec":
                    return 701;
                case "Acambay":
                    return 657;
                case "Huehuetoca":
                    return 691;
                case "Metepec":
                    return 710;
                // Estado de Hidalgo
                case "Hidalgo":
                    return 12;
                case "Tula":
                    return 523;
                case "Tepeji":
                    return 510;
                case "Pachuca":
                    return 495;
                case "Actopan":
                    return 450;
                // Estado de CDMX
                case "CDMX":
                    return 7;
                case "Cuauhtémoc":
                    return 230;
                case "Coyoacán":
                    return 218;
                case "Álvaro Obregón":
                    return 255;
                case "Azcapotzalco":
                    return 217;
                default:
                    return 14;
            }
        }

        private void BtnLista_Clicked(object sender, EventArgs e)
        {
            activityPersonasListPush();
        }
        private async void activityPersonasListPush()
        {
            await Navigation.PushAsync(new ActivityPersonasList());
        }
    }
}
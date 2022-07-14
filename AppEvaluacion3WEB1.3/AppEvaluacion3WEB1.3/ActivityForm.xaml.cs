using AppEvaluacion3WEB1._3.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEvaluacion3WEB1._3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityForm : ContentPage
    {
        public IList<CatEstadoVM> Estados { get; private set; }
        public IList<CatMunicipioVM> Municipios { get; private set; }
        public IList<CatColoniaVM> Colonias { get; private set; }
        public ActivityForm()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeEstados();
        }

        private async void InitializeEstados()
        {
            Estados = new List<CatEstadoVM>();

            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://www.musiclistapi.somee.com/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var url = "api/estados";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var res = await response.Content.ReadAsStringAsync();

                List<CatEstadoVM> estadosRes = JsonConvert.DeserializeObject<List<CatEstadoVM>>(res);

                if (estadosRes.Count > 0)
                {
                    foreach (CatEstadoVM estado in estadosRes)
                    {
                        Estados.Add(estado);
                    }
                }
                else
                {
                    await DisplayAlert("Informacion", "No se encontraron estados disponibles", "Ok");
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                await DisplayAlert("Informacion", "Ocurrio un error al cargar los estados\nPor favor re inicie esta ventana", "Ok");
            }

            BindingContext = this;
        }

        // Llenado de ddl de Municipios
        private async void pickerEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerEstados.SelectedIndex != -1)
            {
                Municipios = new List<CatMunicipioVM>();

                try
                {
                    var client = new HttpClient();
                    client.BaseAddress = new Uri("https://www.musiclistapi.somee.com/");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var url = "api/municipios?id=" + ((CatEstadoVM)pickerEstados.SelectedItem).Id;

                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    var res = await response.Content.ReadAsStringAsync();

                    List<CatMunicipioVM> municipiosRes = JsonConvert.DeserializeObject<List<CatMunicipioVM>>(res);

                    if (municipiosRes.Count > 0)
                    {
                        foreach (CatMunicipioVM municipio in municipiosRes)
                        {
                            Municipios.Add(municipio);
                        }
                    }
                    else
                    {
                        await DisplayAlert("Informacion", "No se encontraron municipios disponibles para el estado seleccionado", "Ok");
                    }

                    //pickerMunicipios.ItemsSource = (System.Collections.IList)Municipios;
                    pickerMunicipios.SetBinding(Picker.ItemsSourceProperty, "Municipios");
                    pickerMunicipios.ItemDisplayBinding = new Binding("Nombre");
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                    await DisplayAlert("Informacion", "Ocurrio un error al cargar los municipios\nPor favor re inicie esta ventana", "Ok");
                }
            }
        }

        // Llenado de ddl de Colonias
        private async void pickerMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerMunicipios.SelectedIndex != -1)
            {
                Colonias = new List<CatColoniaVM>();

                try
                {
                    var client = new HttpClient();
                    client.BaseAddress = new Uri("https://www.musiclistapi.somee.com/");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var url = "api/colonias?id=" + ((CatMunicipioVM)pickerMunicipios.SelectedItem).Id;

                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    var res = await response.Content.ReadAsStringAsync();

                    List<CatColoniaVM> coloniasRes = JsonConvert.DeserializeObject<List<CatColoniaVM>>(res);

                    if (coloniasRes.Count > 0)
                    {
                        foreach (CatColoniaVM colonia in coloniasRes)
                        {
                            Colonias.Add(colonia);
                        }
                    }
                    else
                    {
                        await DisplayAlert("Informacion", "No se encontraron colonias disponibles para el estado seleccionado", "Ok");
                    }

                    //pickerMunicipios.ItemsSource = (System.Collections.IList)Municipios;
                    pickerColonias.SetBinding(Picker.ItemsSourceProperty, "Colonias");
                    pickerColonias.ItemDisplayBinding = new Binding("Nombre");
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                    await DisplayAlert("Informacion", "Ocurrio un error al cargar las colonias\nPor favor re inicie esta ventana", "Ok");
                }
            }
        }

        // ARREGLAR BOTON ENVIAR
        private async void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            if (pickerEstados.SelectedIndex == -1)
            {
                await DisplayAlert("Alerta", "El estado no puede estar vacio", "Ok");
                return;
            }

            if (pickerMunicipios.SelectedIndex == -1)
            {
                await DisplayAlert("Alerta", "El municipio no puede estar vacio", "Ok");
                return;
            }

            if (pickerColonias.SelectedIndex == -1)
            {
                await DisplayAlert("Alerta", "La colonia no puede estar vacio", "Ok");
                return;
            }

            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtaPaterno.Text) ||
                String.IsNullOrEmpty(txtAMaterno.Text) || String.IsNullOrEmpty(txtTelefono.Text) ||
                String.IsNullOrEmpty(txtDireccion.Text))
            {
                await DisplayAlert("Alerta", "Ningun campo puede estar vacio", "Ok");
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
                    IdEstado = ((CatEstadoVM)pickerEstados.SelectedItem).Id,
                    IdMunicipio = ((CatMunicipioVM)pickerMunicipios.SelectedItem).Id,
                    IdColonia = ((CatColoniaVM)pickerColonias.SelectedItem).Id,
                    Direccion = txtDireccion.Text
                };

                Uri RequestUri = new Uri("https://www.musiclistapi.somee.com/app/save");

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
                    txtDireccion.Text = "";
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                await DisplayAlert("Informacion", error, "Ok");
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
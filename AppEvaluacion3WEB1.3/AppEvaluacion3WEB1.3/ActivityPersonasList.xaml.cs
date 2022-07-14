using AppEvaluacion3WEB1._3.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEvaluacion3WEB1._3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityPersonasList : ContentPage
    {
        public IList<PersonaVM> Personas{ get; private set; }
        public ActivityPersonasList()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            // Inicializa la lista de artistas
            InitializeList();
        }

        private async void InitializeList()
        {
            Personas = new List<PersonaVM>();

            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://www.musiclistapi.somee.com");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var url = "app";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var res = await response.Content.ReadAsStringAsync();

                List<PersonaVM> personas = JsonConvert.DeserializeObject<List<PersonaVM>>(res);

                if (personas.Count > 0)
                {
                    foreach(PersonaVM jsonPersona in personas)
                    {
                        Personas.Add(jsonPersona);
                    }
                }
                else
                {
                    await DisplayAlert("Informacion", "No se encontraron usuarios registrados", "Ok");
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                await DisplayAlert("Informacion", "Ocurrio un error inesperado", "Ok");
            }

            BindingContext = this;
            

        }
    }
}
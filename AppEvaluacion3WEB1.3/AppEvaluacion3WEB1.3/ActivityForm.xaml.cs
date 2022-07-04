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
    public partial class ActivityForm : ContentPage
    {
        public ActivityForm()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void pickerMunicipios_Focused(object sender, FocusEventArgs e)
        {
            if (pickerEstados.SelectedIndex != -1)
            {
                switch(pickerEstados.SelectedIndex)
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
                    case 3:
                        pickerMunicipios.ItemsSource = new List<string> {
                            "Cuauhtémoc","Coyoacán","Álvaro Obregón","Azcapotzalco"
                        };
                        break;
                }
            }
        }
    }
}
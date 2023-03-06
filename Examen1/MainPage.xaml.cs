using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btConsultaGeneral_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConsultaGeneral());
        }

        async void btConsultaAula_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConsultarAula());
        }

        async void btModificarEquipo_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ModificarEquipo());
        }
    }
}

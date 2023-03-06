using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Examen1
{
    public partial class ConsultaGeneral : ContentPage
    {
        ListEquipo lequipos = App.LEquipos;
        public ConsultaGeneral()
        {
            InitializeComponent();

            lvLEquipos.ItemsSource = lequipos;
        }

        async void lvLEquipos_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new MostrarEquipo((Equipo)e.SelectedItem));
        }
    }
}

using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Examen1
{
    public partial class ConsultarAula : ContentPage
    {
        ListEquipo lequipos = App.LEquipos;
        public ConsultarAula()
        {
            InitializeComponent();

            lvLEquipos.ItemsSource = lequipos;
        }

        async void lvLEquipos_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new MostrarEquipo((Equipo)e.SelectedItem));
        }

        void pkAula_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            ListEquipo equipos = new ListEquipo();

            foreach(Equipo equipo in lequipos)
            {
                if(equipo.aula.ToString().Equals(pkAula.SelectedItem))
                {
                    equipos.Insertar(equipo);
                }
            }

            lvLEquipos.ItemsSource = equipos;
        }
    }
}

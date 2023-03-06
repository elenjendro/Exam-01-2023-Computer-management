using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Examen1
{
    public partial class ModificarEquipo : ContentPage
    {
        ListEquipo lequipos = App.LEquipos;
        public ModificarEquipo()
        {
            InitializeComponent();
            lvLEquipos.ItemsSource = lequipos;
        }

        void limpiar()
        {
            entId.Text = string.Empty;
            secMod.IsVisible = false;
            secList.IsVisible = true;
            entId.IsEnabled = true;
        }

        void buscar(Equipo equipo)
        {
            pkAula.SelectedItem = equipo.aula.ToString();
            lbPersona.Text = (equipo.persona) ? "Persona: Profesor" : "Persona: Alumno";
            swPersona.IsToggled = equipo.persona;

            secMod.IsVisible = !secMod.IsVisible;
            secList.IsVisible = !secMod.IsVisible; 
            entId.IsEnabled = !entId.IsEnabled;
        }
        async void btBuscar_Clicked(System.Object sender, System.EventArgs e)
        {
            if(string.IsNullOrEmpty(entId.Text))
            {
                await DisplayAlert("Aviso", "Es necesario introducir un Id.", "OK");
            }
            else
            {
                Equipo equipo = lequipos.BuscarEquipo(new Equipo(entId.Text));

                if(equipo != null)
                {
                    buscar(equipo);
                }
                else
                {
                    await DisplayAlert("Aviso", "No existe ningun Equipo con ese Id", "OK");
                }
            }
        }

        void btLimpiar_Clicked(System.Object sender, System.EventArgs e)
        {
            limpiar();
        }

        void swPersona_Toggled(System.Object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            lbPersona.Text = (swPersona.IsToggled) ? "Persona: Profesor" : "Persona: Alumno";
        }

        async void btModificar_Clicked(System.Object sender, System.EventArgs e)
        {
            if(!lequipos.ModificarEquipo(entId.Text, (Aula)Enum.Parse(typeof(Aula), pkAula.SelectedItem.ToString()), swPersona.IsToggled))
            {
                await DisplayAlert("Error", "Ocurrio un error al intentar modificar el elemento", "OK");
            }
            limpiar();
        }

        void lvLEquipos_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Equipo equipo = (Equipo)e.SelectedItem;

            entId.Text = equipo.id;

            buscar(equipo);

            
        }
    }
}

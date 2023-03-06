using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Examen1
{
    public partial class MostrarEquipo : ContentPage
    {
        public MostrarEquipo(Equipo equipo)
        {
            InitializeComponent();

            lbId.Text += equipo.id;
            lbNom.Text += equipo.nom;
            lbTipo.Text += equipo.tipo.ToString();
            lbFecha.Text += equipo.fecha.ToShortDateString();
            lbPersona.Text += (equipo.persona) ? "Profesor" : "Alumno";
            lbAula.Text += equipo.aula.ToString();
        }
    }
}

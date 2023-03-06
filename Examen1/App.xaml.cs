using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1
{
    public partial class App : Application
    {
        public static ListEquipo LEquipos = new ListEquipo();
        public App()
        {
            InitializeComponent();

            LEquipos.datosmock();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

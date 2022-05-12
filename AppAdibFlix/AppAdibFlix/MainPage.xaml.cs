using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAdibFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            btnBatman.Source = ImageSource.FromResource("AppAdibFlix.Posters.batman.jpg");
            btnMorbius.Source = ImageSource.FromResource("AppAdibFlix.Posters.morbius.jpg");
            btnCoraline.Source = ImageSource.FromResource("AppAdibFlix.Posters.coraline.jpg");
            btnDoutor.Source = ImageSource.FromResource("AppAdibFlix.Posters.doutor_estranho.jpg");
          
            btnMoonfall.Source = ImageSource.FromResource("AppAdibFlix.Posters.moonfall.jpg");
            btnDuna.Source = ImageSource.FromResource("AppAdibFlix.Posters.duna.jpg");

            //logo.Source = ImageSource.FromResource("AppAdibFlix.Posters.logo_agora_vai.png");
        }

       

        private void btnBatman_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NovaPasta.batman());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }

           }

        private void btnMorbius_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NovaPasta.morbius());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }


        }

        private void btnCoraline_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NovaPasta.coraline());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }






        }

        private void btnDoutor_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NovaPasta.doutor());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }



        }


        private void btnMoonfall_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NovaPasta.moonfall());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnDuna_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NovaPasta.duna1());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}

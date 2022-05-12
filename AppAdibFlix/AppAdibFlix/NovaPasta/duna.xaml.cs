using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAdibFlix.NovaPasta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class duna : ContentPage
    {
        public duna()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Duna.Source = ImageSource.FromResource("AppAdibFlix.Posters.duna.jpg");

        }
    }
}
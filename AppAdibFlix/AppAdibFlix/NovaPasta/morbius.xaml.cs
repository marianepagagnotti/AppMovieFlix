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
    public partial class morbius : ContentPage
    {
        public morbius()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            Morbius.Source = ImageSource.FromResource("AppAdibFlix.Posters.morbius.jpg");

        }
    }
}
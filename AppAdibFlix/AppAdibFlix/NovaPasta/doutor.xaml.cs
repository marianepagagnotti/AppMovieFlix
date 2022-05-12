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
    public partial class doutor : ContentPage
    {
        public doutor()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Doutor_estranho.Source = ImageSource.FromResource("AppAdibFlix.Posters.doutor_estranho.jpg");

        }
    }
}
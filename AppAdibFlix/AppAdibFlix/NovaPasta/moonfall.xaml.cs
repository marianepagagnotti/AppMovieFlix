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
    public partial class moonfall : ContentPage
    {
        public moonfall()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            Moonfall.Source = ImageSource.FromResource("AppAdibFlix.Posters.moonfall.jpg");
        }
    }
}
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
    public partial class coraline : ContentPage
    {
        public coraline()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Coraline.Source = ImageSource.FromResource("AppAdibFlix.Posters.coraline.jpg");



        }
    }
}
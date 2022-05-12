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
    public partial class batman : ContentPage
    {
        public batman()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Batman.Source = ImageSource.FromResource("AppAdibFlix.Posters.batman.jpg");



        }
    }
}
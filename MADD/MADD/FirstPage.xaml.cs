using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MADD
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        public async void NextPage(object sender, EventArgs e)
        {

           string username = Username.Text;
           await DisplayAlert("Welcome to Microsoft Event (Xamarin Forms)", "Your Name: " + username +  "","Cancel" );
           await Navigation.PushAsync(new DemoPage());
        }
    }
}

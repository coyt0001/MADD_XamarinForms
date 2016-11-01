using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MADD
{
    public partial class DemoPage : ContentPage
    {
        public DemoPage()
        {
            InitializeComponent();
           
        }
        public async void Add(object sender, EventArgs e)
        {
            string text = TodoName.Text;
            NewTodo.Text = "Your New Todo is: " + text;
            await DisplayAlert("Microsoft", "Your Todo "+ text + " been added", "Ok");
        }
    }
}

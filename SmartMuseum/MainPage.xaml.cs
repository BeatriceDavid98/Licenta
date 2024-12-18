using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartMuseum
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Istorie(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MuzeuDeIstorie());
        }

        private void Button_Stiinte(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MuzeuDeStiinte());
        }
    }
}

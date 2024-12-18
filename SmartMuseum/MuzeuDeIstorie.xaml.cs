using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartMuseum
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MuzeuDeIstorie : ContentPage
    {
        public MuzeuDeIstorie()
        {
            InitializeComponent();
        }

        private void Button_Arme(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new arme());
        }
        private void Button_Povestire(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new razboi());
        }

    }
}
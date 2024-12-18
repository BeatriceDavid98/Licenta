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
    public partial class MuzeuDeStiinte : ContentPage
    {
        public MuzeuDeStiinte()
        {
            InitializeComponent();
        }

        private void Button_Balea(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new bealea_template());
      
        }
        private void Button_Pasari(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new pasari_template());
        }
    }
}
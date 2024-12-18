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
    public partial class arme : ContentPage
    {
        public arme()
        {
            InitializeComponent();
        }

        private void Start_Arme(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("sunet_arme.mp3");
            player.Play();
        }
        private void Pause_Arme(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("sunet_arme.mp3");
            player.Pause();
        }

        private void Stop_Arme(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("sunet_arme.mp3");
            player.Stop();
        }

    }
}
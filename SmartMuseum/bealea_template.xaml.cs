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
    public partial class bealea_template : ContentPage
    {
        public bealea_template()
        {
            InitializeComponent();
        }

        private void Story_Start_Balea(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("cascada_balea.mp3");
            player.Play();
        }
        private void Story_Pause_Balea(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("cascada_balea.mp3");
            player.Pause();
        }

        private void Story_Stop_Balea(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("cascada_balea.mp3");
            player.Stop();
        }

        private void Sound_Start_Balea(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("cascada_balea_sonor_apa.mp3");
            player.Play();
        }
        private void Sound_Pause_Balea(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("cascada_balea_sonor_apa.mp3");
            player.Pause();
        }

        private void Sound_Stop_Balea(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("cascada_balea_sonor_apa.mp3");
            player.Stop();
        }
    }
}
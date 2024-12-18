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
    public partial class pasari_template : ContentPage
    {
        public pasari_template()
        {
            InitializeComponent();
        }

        private void Story_Start(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("pasari_calatoare.mp3");
            player.Play();
        }
        private void Story_Pause(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("pasari_calatoare.mp3");
            player.Pause();
        }

        private void Story_Stop(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("pasari_calatoare.mp3");
            player.Stop();
        }

        private void Sound_Start(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("pasari_calatoare_sunet.mp3");
            player.Play();
        }
        private void Sound_Pause(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("pasari_calatoare_sunet.mp3");
            player.Pause();
        }

        private void Sound_Stop(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("pasari_calatoare_sunet.mp3");
            player.Stop();
        }
    }
}
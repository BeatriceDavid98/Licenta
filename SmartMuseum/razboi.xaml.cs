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
    public partial class razboi : ContentPage
    {
        public razboi()
        {
            InitializeComponent();
        }

        private void Start_Razboi(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("descrierea_razboiului.mp3");
            player.Play();
        }
        private void Pause_Razboi(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("descrierea_razboiului.mp3");
            player.Pause();
        }

        private void Stop_Razboi(object sender, System.EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("descrierea_razboiului.mp3");
            player.Stop();
        }
    }
}
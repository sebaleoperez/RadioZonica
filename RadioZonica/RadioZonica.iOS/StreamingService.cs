using RadioZonica.iOS;
using AVFoundation;
using Foundation;
using Xamarin.Forms;
using RadioZonica.Interfaces;

[assembly: Dependency(typeof(StreamingService))]
namespace RadioZonica.iOS
{
    class StreamingService : IStreaming
    {
        AVPlayer player;
        string dataSource = "http://streamlky.alsolnet.com:443/radiozonica";

        bool IsPrepared = false;

        public void Play()
        {
            AVAudioSession.SharedInstance().SetCategory(AVAudioSessionCategory.Playback);
            if (!IsPrepared || player == null)
                player = AVPlayer.FromUrl(NSUrl.FromString(dataSource));

            IsPrepared = true;
            player.Play();
        }

        public void Pause()
        {
            player.Pause();
        }

        public void Stop()
        {
            player.Dispose();
            IsPrepared = false;
        }
    }
}
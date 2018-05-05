using RadioZonica.Interfaces;
using Android.Media;
using RadioZonica.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(StreamingService))]
namespace RadioZonica.Droid
{
    public class StreamingService : IStreaming
    {
        MediaPlayer player;
        string dataSource = "rtsp://streamlky.alsolnet.com/radiozonica/radiozonica.stream";

        bool IsPrepared = false;

        public void Play()
        {
            if (!IsPrepared)
            {
                if (player == null)
                    player = new MediaPlayer();
                else
                    player.Reset();

                player.SetDataSource(dataSource);
                player.PrepareAsync();
            }

            player.Prepared += (sender, args) =>
            {
                player.Start();
                IsPrepared = true;
            };
        }

        public void Pause()
        {
            player.Pause();
        }

        public void Stop()
        {
            player.Stop();
            IsPrepared = false;
        }
    }
}
using RadioZonica.Pages;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace RadioZonica
{
    public partial class App : Application
    {
        public static MasterDetailPage MenuItem { get; set; }
        public static bool IsPLaying { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=086afe69-1e12-41c1-a098-853c09741168;" +
                  "uwp={Your UWP App secret here};" +
                  "ios=19cb361f-31c2-41fb-b81b-844338c7533f;",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

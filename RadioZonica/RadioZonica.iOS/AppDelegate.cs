using Foundation;
using ObjCRuntime;
using UIKit;
using Firebase.Analytics;

namespace RadioZonica.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            UIApplication.SharedApplication.SetMinimumBackgroundFetchInterval(UIApplication.BackgroundFetchIntervalMinimum);

			Firebase.Core.App.Configure();
			Analytics.LogEvent(EventNamesConstants.AppOpen, null);

            LoadApplication(new App());         
         
            return base.FinishedLaunching(app, options);
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations(UIApplication application, [Transient] UIWindow forWindow)
        {
            return UIInterfaceOrientationMask.Portrait;
        }
    }
}

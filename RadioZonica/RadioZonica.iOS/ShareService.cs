using Foundation;
using UIKit;
using RadioZonica.Interfaces;
using RadioZonica.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(ShareService))]
namespace RadioZonica.iOS
{
    class ShareService : ISocial
    {
        public void ShareLink(string Text)
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var rootViewController = window.RootViewController;

            var activityViewController = new UIActivityViewController(new NSString[] { new NSString(Text) }, null);

            rootViewController.PresentViewController(activityViewController, true, null);
        }
    }
}
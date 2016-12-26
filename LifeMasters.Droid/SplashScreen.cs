
using Android.App;
using MvvmCross.Droid.Views;
using Android.Content.PM;

namespace LifeMasters.Droid
{
    [Activity(
        MainLauncher = true,
        Label = "@string/ApplicationName",
        NoHistory = true,
        Theme = "@style/MyTheme.Splash",
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.splash_screen)
        {
        }
    }
}
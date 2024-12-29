#pragma warning disable IDE0130
// ReSharper disable once CheckNamespace
namespace MauiPad;

using Android.App;
using Android.Content.PM;
using Android.OS;

using AndroidX.Core.View;

[Activity(
    Theme = "@style/Maui.SplashTheme",
    MainLauncher = true,
    LaunchMode = LaunchMode.SingleTop,
    ScreenOrientation = ScreenOrientation.Landscape,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        if (Window is not null)
        {
            WindowCompat.SetDecorFitsSystemWindows(Window, false);
            using var windowInsetsController = new WindowInsetsControllerCompat(Window, Window.DecorView);
            windowInsetsController.Hide(WindowInsetsCompat.Type.SystemBars());
            windowInsetsController.SystemBarsBehavior = WindowInsetsControllerCompat.BehaviorShowTransientBarsBySwipe;
        }
    }
}

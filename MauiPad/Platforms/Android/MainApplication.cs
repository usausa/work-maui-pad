#pragma warning disable IDE0130
// ReSharper disable once CheckNamespace
namespace MauiPad;

using Android.App;
using Android.Runtime;

[Application]
public class MainApplication : MauiApplication
{
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

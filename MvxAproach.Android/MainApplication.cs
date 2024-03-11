using Android.Runtime;
using MvvmCross.Platforms.Android.Views;
using MvxAproach.Core;

namespace MvxAproach.Android;

[Application]
public sealed class MainApplication : MvxAndroidApplication<Setup, App>
{
    public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
    }
}
using MobileNetNative.Core;

namespace MobileNetNative.Droid;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        var mainScreen = new MainScreen();
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        var textView = FindViewById<TextView>(Resource.Id.textGreetings);
        textView.Text = mainScreen.Greetings;
    }
}
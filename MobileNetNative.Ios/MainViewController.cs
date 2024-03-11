using System;

using UIKit;
using Foundation;

namespace MobileNetNative.Ios;

[Register("MainViewController")]
public partial class MainViewController : UIViewController
{
    private UIWindow _window;
    public MainViewController(UIWindow uiWindow) : base("MainViewController", null)
    {
        _window = uiWindow;
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();
        CreateView();
    }

    private void CreateView()
    {
        View!.AddSubview(new UILabel(_window!.Frame)
        {
            BackgroundColor = UIColor.SystemBackground,
            TextAlignment = UITextAlignment.Center,
            Text = "Hello, iOS!",
            AutoresizingMask = UIViewAutoresizing.All,
        });
    }

    public override void DidReceiveMemoryWarning()
    {
        base.DidReceiveMemoryWarning();
        // Release any cached data, images, etc that aren't in use.
    }
}
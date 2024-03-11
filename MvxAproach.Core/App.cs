using MvvmCross.ViewModels;
using MvxAproach.Core.ViewModels;

namespace MvxAproach.Core;

public class App : MvxApplication
{
    public override void Initialize()
    {
        // This only works on Android if you are using MvxSetupActivity and will otherwise be ignored
        RegisterAppStart<MainViewModel>();
    }
}
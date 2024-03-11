using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvxAproach.Core.ViewModels;

public sealed class DetailViewModel : MvxViewModel<DetailParameters>
{
    public string DetailText { get; private set; } = string.Empty;
    
    public IMvxAsyncCommand CloseCommand { get; }

    public DetailViewModel(IMvxNavigationService navigationService)
    {
        CloseCommand = new MvxAsyncCommand(() => navigationService.Close(this));
    }
    
    public override void Prepare(DetailParameters parameter)
    {
        DetailText = $"We had {parameter.Clicks} clicks on previous screen";
    }
}


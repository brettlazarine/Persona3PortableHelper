using P3PHelper.MVVM.ViewModels;

namespace P3PHelper.MVVM.Views.SLinks;
public partial class SLinkInteraction : ContentPage
{
    public SLinkInteraction(InteractionStoryViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}
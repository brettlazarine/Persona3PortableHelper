using P3PHelper.MVVM.ViewModels;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.SLinks;
public partial class SLinkStory : ContentPage
{
    public SLinkStory(InteractionStoryViewModel viewModel)
    {
        InitializeComponent();
        
        BindingContext = viewModel;
    }
}
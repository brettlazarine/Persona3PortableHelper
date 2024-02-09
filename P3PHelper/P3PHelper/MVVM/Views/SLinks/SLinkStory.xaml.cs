using P3PHelper.MVVM.ViewModels;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.SLinks;
public partial class SLinkStory : ContentPage
{
    public InteractionStoryViewModel Vm { get; set; }
    public SLinkStory()
	{
		InitializeComponent();
	}

    public SLinkStory(InteractionStoryViewModel vm)
    {
        InitializeComponent();
        Vm = vm;
        BindingContext = Vm;
    }
}
using P3PHelper.MVVM.ViewModels;

namespace P3PHelper.MVVM.Views.SLinks;
public partial class SLinkInteraction : ContentPage
{
    public InteractionStoryViewModel Vm { get; set; }
    public SLinkInteraction()
	{
		InitializeComponent();
	}

    public SLinkInteraction(InteractionStoryViewModel vm)
    {
        InitializeComponent();
        Vm = vm;
        BindingContext = Vm;
    }
}
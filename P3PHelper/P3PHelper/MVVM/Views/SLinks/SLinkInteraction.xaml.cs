using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.SLinks;

public partial class SLinkInteraction : ContentPage
{
	public SLinkInteraction()
	{
		InitializeComponent();
	}

    public SLinkInteraction(string arcanaName)
    {
        InitializeComponent();

        var sLinkRepo = DependencyService.Get<SLinkRepository>();
        var sLink = sLinkRepo.GetSLink(arcanaName);

        BindingContext = sLink;
    }
}
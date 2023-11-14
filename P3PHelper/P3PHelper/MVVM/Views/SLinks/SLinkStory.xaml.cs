using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;

namespace P3PHelper.MVVM.Views.SLinks;

public partial class SLinkStory : ContentPage
{
	public SLinkStory()
	{
		InitializeComponent();
	}

    public SLinkStory(string arcanaName)
    {
        InitializeComponent();

        var sLinkRepo = DependencyService.Get<SLinkRepository>();
        var sLink = sLinkRepo.GetSLink(arcanaName);

        BindingContext = sLink;
    }
}
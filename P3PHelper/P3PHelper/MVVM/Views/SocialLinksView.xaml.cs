using Microsoft.AppCenter.Crashes;
using Microsoft.Maui.Controls.Xaml;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.MVVM.Views.SLinks;
using System.Diagnostics;
using System.Globalization;

namespace P3PHelper.MVVM.Views;

public partial class SocialLinksView : ContentPage
{

	public SocialLinksView(SocialLinksViewModel viewModel)
	{
		InitializeComponent();

        //Crashes.GenerateTestCrash();
        BindingContext =viewModel;
	}
}
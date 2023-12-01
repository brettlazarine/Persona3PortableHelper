using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper;

public partial class MainPage : ContentPage
{
	ProgressRepository ProgressRepo;
	public MainPage()
	{
		InitializeComponent();

		ProgressRepo = App.ProgressRepo;

		var sLinks = ProgressRepo.GetSLinks();

		BindingContext = sLinks;
	}

	
}


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

		//Debug.WriteLine("***** SLinks *****");
		//foreach (var sLink in sLinks)
		//{
		//	Debug.WriteLine($"* {sLink.Arcana} *");
		//}

		//Debug.WriteLine("***** RankUps *****");
		//foreach (var item in ProgressRepo.GetRankUps())
		//{
		//	Debug.WriteLine($"* ID: {item.RankUpId} " +
		//	$"Arcana: {item.Arcana}, " +
		//	$"Rank: {item.RankNumber}, " +
		//	$"Male: {item.IsCompleted} *");
		//}

		var test = ProgressRepo.GetSLink("fool");
		try
		{
			Debug.WriteLine($"****** {test.Arcana} *****");
		}
		catch
		{
			Debug.WriteLine("***** DID NOT WORK *****");
		}
	}

	
}


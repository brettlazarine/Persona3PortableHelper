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

		BindingContext = sLinks.ToString();

		Debug.WriteLine("***** SLinks *****");
		foreach (var sLink in sLinks)
		{
			Debug.WriteLine($"* {sLink.Arcana} *");
		}

		Debug.WriteLine("***** RankUps *****");
		foreach (var item in ProgressRepo.GetRankUps())
		{
			Debug.WriteLine($"* ID: {item.RankUpId} " +
			$"Arcana: {item.SLinkArcana}, " +
			$"Rank: {item.RankNumber}, " +
			$"Male: {item.IsCompletedMale}, " +
			$"Female: {item.IsCompletedFemale} *");
		}
	}

	
}


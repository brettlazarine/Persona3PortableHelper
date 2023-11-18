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

		BindingContext = ProgressRepo.GetSLinks();

		//Debug.WriteLine(ProgressRepo.GetSLinks().Count);
		//foreach (var item in ProgressRepo.GetSLinks())
		//{
  //          Debug.WriteLine("********** " + item.Arcana);
  //      }

		foreach (var item in ProgressRepo.GetRankUps())
		{
            Debug.WriteLine($"Arcana: {item.SLinkArcana}, " +
				$"Rank: {item.RankNumber}, " +
				$"Male: {item.IsCompletedMale}, " +
				$"Female: {item.IsCompletedFemale}");
        }
	}

	
}


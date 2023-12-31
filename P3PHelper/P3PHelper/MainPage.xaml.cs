﻿using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;

namespace P3PHelper;

public partial class MainPage : ContentPage
{
	ProgressRepository ProgressRepo;
	public ObservableCollection<SLink> SLinks { get; set; } = new();
	public MainPage()
	{
		InitializeComponent();

		//ProgressRepo = App.ProgressRepo;

		//var sLinks = ProgressRepo.GetSLinks();


		//var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
		//using (Stream stream = assembly.GetManifestResourceStream("P3PHelper.Resources.Raw.persona3.db3"))
		//{
		//	using (MemoryStream memoryStream = new MemoryStream())
		//	{
		//		stream.CopyTo(memoryStream);
		//		File.WriteAllBytes(ProgressRepository.DbPath, memoryStream.ToArray());
		//	}
		//}

		ProgressRepository repo = new();
		var link = repo.GetSLinks().FirstOrDefault();
		BindingContext = link;

		try
		{
			var reqs = repo.GetRequests();
            Debug.WriteLine($"*** {reqs.Count} requests ***");
        }
		catch (Exception ex)
		{
            Debug.WriteLine("*** " + ex.Message + " ***");
        }
		Debug.WriteLine("*** AFTER GETREQUESTS ***");
		
	}

    
}


using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using P3PHelper.Utilities;
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
	}

    
}


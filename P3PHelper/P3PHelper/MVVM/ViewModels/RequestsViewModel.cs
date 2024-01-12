using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P3PHelper.MVVM.ViewModels
{
    public partial class RequestsViewModel: ObservableObject
    {
        ProgressRepository ProgressRepo = new();

        [ObservableProperty]
        List<Request> currentRequest;

        public List<Request> OneTwenty { get; set; } = new();
        public List<Request> TwentyOneFourty { get; set; } = new();
        public List<Request> FourtyOneSixty { get; set; } = new();
        public List<Request> SixtyOneEighty { get; set; } = new();

        public RequestsViewModel()
        {
            foreach (var req in ProgressRepo.GetRequests())
            {
                req.HowToComplete = req.HowToComplete.Replace("\\n", Environment.NewLine);
                req.Reward = req.Reward.Replace("\\n", Environment.NewLine);
                if (req.QuestNumber <= 20)
                {
                    OneTwenty.Add(req);
                }
                else if (req.QuestNumber <= 40)
                {
                    TwentyOneFourty.Add(req);
                }
                else if (req.QuestNumber <= 60)
                {
                    FourtyOneSixty.Add(req);
                }
                else if (req.QuestNumber <= 80)
                {
                    SixtyOneEighty.Add(req);
                }
            }
        }

        // Avoided this, verify that it is not needed
        public List<Request> SetCurrentRequests(string groupName)
        {
            if (groupName == "One To Twenty View")
            {
                return OneTwenty;
            }
            else if (groupName == "Twenty One Fourty View")
            {
                return TwentyOneFourty;
            }
            else if (groupName == "Fourty One Sixty View")
            {
                return FourtyOneSixty;
            }
            else if (groupName == "Sixty One Eighty View")
            {
                return SixtyOneEighty;
            }
            else
            {
                return null;
            }
        }

        private async void RequestCheckBoxChangedVM(object sender, CheckedChangedEventArgs e)
        {
            if (sender is not CheckBox checkBox)
            {
                Debug.WriteLine("*** Unexpected sender type in CheckBox_CheckedChanged ***");
                return;
            }
            if (checkBox.BindingContext is not Request request)
            {
                Debug.WriteLine("*** Unexpected BindingContext type in RequestCheckBox_CheckedChanged ***");
                return;
            }
            // Toggle the IsVisible property of the RequestDetails Grid
            try
            {
                var parent = checkBox.Parent as Layout;
                if (parent == null)
                {
                    Debug.WriteLine("*** Parent is null in RequestCheckBox_CheckedChanged ***");
                    return;
                }

                var hider = parent.Children
                    .OfType<Grid>()
                    .FirstOrDefault(x => x.AutomationId == "RequestDetails");
                if (hider != null)
                {
                    hider.IsVisible = !hider.IsVisible;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error handling CheckBox tapped: {ex.Message} ***");

                await App.Current.MainPage.DisplayAlert("Error", "Error handling CheckBox tap", "OK");
            }
            // Update the Request in the database
            try
            {
                int isCompleted = checkBox.IsChecked ? 1 : 0;
                //App.ProgressRepo.UpdateRequest(request.QuestNumber, isCompleted);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error updating Request: {ex.Message}   ***");

                await App.Current.MainPage.DisplayAlert("Error", "Error updating Request", "OK");
            }
        }
    }
}

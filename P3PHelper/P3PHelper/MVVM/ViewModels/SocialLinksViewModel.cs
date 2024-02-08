using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.Views.SLinks;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Input;

namespace P3PHelper.MVVM.ViewModels
{
    public class SocialLinksViewModel
    {
        private INavigation Navigation { get; set; } = Application.Current?.MainPage?.Navigation;
        private Page Page { get; set; } = new Page();

        public List<SLinkTapInfo> TapInfo { get; set; }
        public List<string> StorySLinks { get; set; } = new()
        {
            "death",
            "fool",
            "judgment"
        };

        public ICommand NaviageToSLinkCommand { get; }

        public SocialLinksViewModel()
        {
            // Placeholder for navigation and data binding
            TapInfo = new()
            {
                new SLinkTapInfo()
                {
                    ArcanaName = "Aeon",
                    ImageSource = "aeon"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Chariot",
                    ImageSource = "chariot"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Death",
                    ImageSource = "death"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Devil",
                    ImageSource = "devil"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Emperor",
                    ImageSource = "emperor"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Empress",
                    ImageSource = "empress"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Fool",
                    ImageSource = "fool"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Fortune",
                    ImageSource = "fortune"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Hanged Man",
                    ImageSource = "hangedman"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Hermit",
                    ImageSource = "hermit"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Hierophant",
                    ImageSource = "hierophant"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Judgment",
                    ImageSource = "judgment"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Justice",
                    ImageSource = "justice"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Lovers",
                    ImageSource = "lovers"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Magician",
                    ImageSource = "magician"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Moon",
                    ImageSource = "moon"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Priestess",
                    ImageSource = "priestess"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Star",
                    ImageSource = "star"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Strength",
                    ImageSource = "strength"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Sun",
                    ImageSource = "sun"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Temperance",
                    ImageSource = "temperance"
                },
                new SLinkTapInfo()
                {
                    ArcanaName = "Tower",
                    ImageSource = "tower"
                },
            };

            NaviageToSLinkCommand = new Command<SLinkTapInfo>(NavigateToSLink);
        }

        private async void NavigateToSLink(SLinkTapInfo tapInfo)
        {
            try
            {
                var arcanaName = tapInfo.ArcanaName;
                Debug.WriteLine($"*** Navigating to {arcanaName} ***");

                var vm = new InteractionStoryViewModel(arcanaName);
                await vm.EnsureInitializedAsync(arcanaName);

                if (StorySLinks.Contains(arcanaName.ToLower()))
                {
                    await Navigation.PushAsync(new SLinkStory(vm));
                    //await Shell.Current.GoToAsync("slinkInteraction");
                }
                else
                {
                    await Navigation.PushAsync(new SLinkInteraction(vm));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error handling SLink navigation: {ex.Message} ***");
                await Application.Current.MainPage.DisplayAlert("Error", "Error navigating to SLink. Please try again.", "OK");
            }
        }
    }
}

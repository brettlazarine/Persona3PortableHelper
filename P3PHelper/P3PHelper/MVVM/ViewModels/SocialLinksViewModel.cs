using P3PHelper.MVVM.Models;

namespace P3PHelper.MVVM.ViewModels
{
    public class SocialLinksViewModel
    {
        public List<SLinkTapInfo> TapInfo { get; set; }
        public List<string> StorySLinks { get; set; } = new()
        {
            "death",
            "fool",
            "judgment"
        };

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
        }

        
    }
}

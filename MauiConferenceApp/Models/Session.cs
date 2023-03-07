using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiConferenceApp.Models
{
    public partial class Session : ObservableObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Room { get; set; }
        public string Description { get; set; }
        public Speaker Speaker { get; set; } = new Speaker
        {
            //Dummy Speaker Data
            Id = 1,
            Name = "Thomas Crowe",
            Bio = "Dev from Greenville,SC",
            Company = "Arnold's",
            Title = "CEO",
            Twitter = "https://twitter.com/tcrowe_iv",
            Website = "https://github.com/wtcrowe4",
            Image = "https://avatars.githubusercontent.com/u/100397211?v=4"
        };
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string StartTimeDisplay => StartTime.ToString("hh:mm tt");
        public string EndTimeDisplay => EndTime.ToString("hh:mm tt");
        public string TimeDisplay => $"{StartTimeDisplay} - {EndTimeDisplay}";
        public string DayDisplay => StartTime.ToString("ddd");

        [ObservableProperty]
        bool inAgenda;


    }
}

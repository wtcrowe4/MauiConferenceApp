using CommunityToolkit.Mvvm.Input;
using MvvmHelpers;
using MauiConferenceApp.Models;

namespace MauiConferenceApp.ViewModels
{
    public partial class ScheduleViewModel : ObservableObject
    {
        public int Day { get; set; }
        public ObservableRangeCollection<Grouping<string, Session>> Schedule { get; } = new();
        Random random = new();

        public ScheduleViewModel() 
        { 
        
        }
        
        [RelayCommand]
        public Task LoadDataAsync()
        {
            //Dummy Data
            var sessionCount = new[] { 1, 2, 4, 4, 4, 4, 4 };
            var sessions = new List<Session>();
            foreach(var i in sessionCount)
            {
                AddItems(sessionCount[i], i);
                //This will eventually sort by time, dummy data has same start time.
                var sorted = from session in sessions
                             orderby session.StartTime
                             group session by session.StartTimeDisplay into sessionGroup
                             select new Grouping<string, Session>(sessionGroup.Key, sessionGroup);
                
                Schedule.AddRange(sorted);
            }

            return Task.CompletedTask;
            
            void AddItems(int count, int offset)
            {
                for (int i = 0; i < count; i++)
                {
                    sessions.Add(new Session
                    {
                        Id = i,
                        Title = $"Session {i}, {offset}",
                        Room = $"Room 10{i}",
                        Description = $"Session {i} Description",
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddHours(offset)
                    });
                }
                
            }
        }

    }
}


//public class ScheduleDay1ViewModel : ScheduleViewModel
//{
//    public ScheduleDay1ViewModel() { Day = 1; }
//}
//public class ScheduleDay2ViewModel : ScheduleViewModel
//{
//    public ScheduleDay2ViewModel() { Day = 2; }
//}
//public class ScheduleDay3ViewModel : ScheduleViewModel
//{
//    public ScheduleDay3ViewModel() { Day = 3; }

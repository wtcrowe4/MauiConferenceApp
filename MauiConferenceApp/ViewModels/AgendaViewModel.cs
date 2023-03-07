namespace MauiConferenceApp.ViewModels
{
    
    public class AgendaDay1ViewModel : AgendaViewModel
    {
        public AgendaDay1ViewModel() { Day = 1; }
    }
    public class AgendaDay2ViewModel : AgendaViewModel
    {
        public AgendaDay2ViewModel() { Day = 2; }
    }
    public class AgendaDay3ViewModel : AgendaViewModel
    {
        public AgendaDay3ViewModel() { Day = 3; }
    }

    public partial class AgendaViewModel : ObservableObject
    {
        public int Day { get; set; }
        
        public ObservableRangeCollection<Grouping<string, Session>> Agenda { get; } = new();
        
        public AgendaViewModel() 
        { 
        
        }
        [RelayCommand]
        Task LoadDataAsync()
        {
            //Dummy Data
            var sessionCount = new[] { 1, 2, 4, 4, 4, 4, 4 };
            var sessions = new List<Session>();
            foreach(var i in sessionCount)
            {
                AddItems(sessionCount[i], i);
                //var sorted = from session in sessions
                //             orderby session.Id
                //             group session by sessionCount[i] into sessionGroup
                //             select new Grouping<string, Session>(sessionGroup.Key, sessionGroup);
                //Agenda.AddRange(sorted);
                Agenda.AddRange((IEnumerable<Grouping<string, Session>>)sessions[i]);
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

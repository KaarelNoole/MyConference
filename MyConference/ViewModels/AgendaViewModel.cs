using CommunityToolkit.Mvvm.Input;
using Jeffsum;
using Models;
using MvvmHelpers;
using static Jeffsum.Goldblum;



namespace ViewModels;

public partial class AgendaViewModel : ObservableObject
{
    public int Day { get; set; }
    public ObservableRangeCollection<Grouping<string, Session>> Agenda { get; } = new ObservableRangeCollection<Grouping<string, Session>>();
    Random random = new();
    public AgendaViewModel()
    {

    }

    [RelayCommand]
    Task LoadDataAsync()
    {
        var sessionCount = new[] { 1, 2, 4, 4, 4, 4, 4 };
        var sessions = new List<Session>();
        var start = new DateTime(2022, 9, Day, 8, 30, 0);
        for (int i = 0; i < sessionCount.Length; i++)
        
            AddItems(sessionCount[i], i);
        


        return Task.CompletedTask;

        void AddItems(int count, int offset)
        {
            for (int i = 0; i < count; i++)
            {
                sessions.Add(new Session
                {
                    Title =  string.Join(" ", ReceiveTheJeff(random.Next(2, 5), JeffsumType.Words)),
                    Description = ReceiveTheJeff(1).First(),
                    Room = "Goldblum",
                    Start = start.AddHours(offset),
                    End = start.AddHours(offset + 1)
                });
            }
            
        }
    }
}

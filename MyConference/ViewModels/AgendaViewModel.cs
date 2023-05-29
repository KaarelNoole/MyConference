
using CommunityToolkit.Mvvm.Input;
using Models;
using MvvmHelpers;
namespace ViewModels;

public partial class AgendaViewModel : ObservableObject
{
    public ObservableRangeCollection<Grouping<string, Session>> Agenda { get; } = new ObservableRangeCollection<Grouping<string, Session>>();

    public AgendaViewModel()
    {

    }

    [RelayCommand]
    Task LoadDataAsync()
    {

    }
}

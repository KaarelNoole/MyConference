using Microsoft.Maui.Controls;
using ViewModels;

namespace Pages;

public partial class ScheduleDay1Page : SchedulePage
{
	public ScheduleDay1Page(ScheduleViewModel vm) : base()
	{
		vm.Day = 1;
		BindingContext = vm;
	}
}

public partial class ScheduleDay2Page : SchedulePage
{
    public ScheduleDay2Page(ScheduleViewModel vm) : base()
    {
        vm.Day = 1;
        BindingContext = vm;
    }
}
public partial class SchedulePage : ContentPage
{
	ScheduleViewModel vm;

    ScheduleViewModel VM => vm ??= BindingContext as ScheduleViewModel;
    public SchedulePage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.Schedule.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }
}
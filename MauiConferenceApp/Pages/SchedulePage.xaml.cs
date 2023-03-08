using Microsoft.Maui.Controls;
using MauiConferenceApp.ViewModels;
using System.Diagnostics;

namespace MauiConferenceApp.Pages;
public partial class ScheduleDay1Page : SchedulePage
{
    public ScheduleDay1Page(ScheduleViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "Schedule - Day 1";
        BindingContext = vm;
    }
}
public partial class ScheduleDay2Page : SchedulePage
{
    public ScheduleDay2Page(ScheduleViewModel vm) : base()
    {
        vm.Day = 2;
        Title = "Schedule - Day 2";
        BindingContext = vm;
    }
}
public partial class ScheduleDay3Page : SchedulePage
{
    public ScheduleDay3Page(ScheduleViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "Schedule - Day 3";
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
        //System.NullReferenceException: 'Object reference not set to an instance of an object.'
        //MauiConferenceApp.Pages.SchedulePage.VM.get returned null.
        if (vm.Schedule.Count == 0)
            //await VM.LoadDataAsync();
            await vm.LoadDataCommand.ExecuteAsync(null);
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

}


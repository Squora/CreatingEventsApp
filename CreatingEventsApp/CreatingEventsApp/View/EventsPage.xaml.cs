using CreatingEventsApp.Models;
using CreatingEventsApp.View;
using System.Diagnostics;

namespace CreatingEventsApp;

public partial class EventsPage : ContentPage
{
    public EventInfoModel EventInfo { get; set; }

	public EventsPage()
	{
		InitializeComponent();

        btnGroups.Clicked += LoadGroupsPage;
        btnProfile.Clicked += LoadProfilePage;

        EventInfo = new EventInfoModel()
        {
            EventName = "Карьерный марафон",
            Organizer = "Московский политех",
            Description = "Карьерный марафон: ускорь свой успех - это интенсивное мероприятие, нацеленное на помощь участникам в достижении новых высот...",
            Location = "ул.Большая Семеновская 38",
            StartTime = "14:20",
            EndTime = "18:00"
        };

        BindingContext = EventInfo;
    }

    private async void CreateEventTapped(object sender, TappedEventArgs args)
    {
        await Navigation.PushAsync(new CreateEventPage());
    }

    private async void EventFrameTapped(object sender, TappedEventArgs args)
    {
        await Navigation.PushAsync(new EventInfoPage());
    }

    private async void LoadGroupsPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void LoadProfilePage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfilePage());
    }

    public void CreateEvent(string eventName, string eventOrganizer, string eventDescription, string eventLocation,
        string eventTime)
    {
        var stackLayout = new StackLayout();
        var grid = new Grid();
        var columnDef = new ColumnDefinition();
        var columnDef2 = new ColumnDefinition();
        var rowDef = new RowDefinition();
        var rowDef2 = new RowDefinition();
        rowDef2.Height = 70;
        var rowDef3 = new RowDefinition();

        grid.ColumnDefinitions.Add(columnDef);
        grid.ColumnDefinitions.Add(columnDef2);
        grid.RowDefinitions.Add(rowDef);
        grid.RowDefinitions.Add(rowDef2);
        grid.RowDefinitions.Add(rowDef3);

        var frame = new Frame
        {
            BorderColor = Colors.Black,
            Padding = 10,
            CornerRadius = 10
        };

        var tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += EventFrameTapped;

        frame.GestureRecognizers.Add(tapGestureRecognizer);

        stackLayout.Children.Add(frame);

        var lblEventName = new Label
        {
            Text = eventName,
            HorizontalOptions = LayoutOptions.Start,
        };

        grid.SetRow(lblEventName, 0);
        grid.SetColumn(lblEventName, 0);

        var lblEventOrganizer = new Label
        {
            Text = eventOrganizer,
            HorizontalOptions = LayoutOptions.End
        };

        grid.SetRow(lblEventOrganizer, 0);
        grid.SetColumn(lblEventOrganizer, 1);

        var lblEventDescription = new Label
        {
            Text = eventDescription,
            Margin = new Thickness(0, 5, 0, 0)
        };

        grid.SetRow(lblEventDescription, 1);
        grid.SetColumnSpan(lblEventDescription, 2);

        var lblEventLocation = new Label
        {
            Text = eventLocation,
        };

        grid.SetRow(lblEventLocation, 2);
        grid.SetColumn(lblEventLocation, 0);

        var lblEventTime = new Label
        {
            Text = eventTime,
            HorizontalOptions = LayoutOptions.End
        };

        grid.SetRow(lblEventTime, 2);
        grid.SetColumn(lblEventTime, 1);

        grid.Add(lblEventName);
        grid.Add(lblEventOrganizer);
        grid.Add(lblEventDescription);
        grid.Add(lblEventLocation);
        grid.Add(lblEventTime);

        frame.Content = new StackLayout
        {
            Children = { grid }
        };

        EventsList.Children.Add(stackLayout);
    }
}
namespace CreatingEventsApp.View;

public partial class EventHistoryPage : ContentPage
{
	public EventHistoryPage()
	{
		InitializeComponent();
	}

    private async void btnRestoreEvent_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RestoreEventPage());
    }

    private async void btn—ancel—hanges_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CancelChangesPage());
    }

    private async void btnCreateEvent_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateEventInfoPage());
    }

    private async void btnBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfilePage());
    }
}
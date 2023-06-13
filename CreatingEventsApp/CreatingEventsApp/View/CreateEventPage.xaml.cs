namespace CreatingEventsApp.View;

public partial class CreateEventPage : ContentPage
{
    EventsPage eventsPage = new EventsPage();

	public CreateEventPage()
	{
		InitializeComponent();
	}

    private async void btnCreate_Clicked(object sender, EventArgs e)
    {
		if (eEventName.Text != null && eEventOrganizer.Text != null && eEventDescription.Text != null && eEventLocation.Text
            != null && eEventStartTime.Text != null && eEventEndTime.Text != null)
		{
            eventsPage.CreateEvent(eEventName.Text, eEventOrganizer.Text, eEventDescription.Text, eEventLocation.Text,
                eEventStartTime.Text + "-" + eEventEndTime.Text);
            await Navigation.PushAsync(eventsPage);
        }
        else
        {
            await DisplayAlert("Ошибка", "Заполните все поля", "OK");
        }
    }
}
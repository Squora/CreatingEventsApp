namespace CreatingEventsApp.View;

public partial class EventInfoPage : ContentPage
{
	public EventInfoPage()
	{
		InitializeComponent();
	}

    private async void btnEdit_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditEventPage());
    }

    private async void btnDelete_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Успешно", "Мероприятие было удалено", "OK");
        await Navigation.PushAsync(new EventsPage());
    }
}
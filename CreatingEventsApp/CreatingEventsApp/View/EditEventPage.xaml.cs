namespace CreatingEventsApp.View;

public partial class EditEventPage : ContentPage
{
	public EditEventPage()
	{
		InitializeComponent();
	}

    private async void btnSave_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Успешно", "Мероприятие было изменено", "OK");
        await Navigation.PushAsync(new EventsPage());
    }
}
namespace CreatingEventsApp.View;

public partial class RestoreEventPage : ContentPage
{
	public RestoreEventPage()
	{
		InitializeComponent();
	}

    private async void btnRestore_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Успешно", "Мероприятие было восстановлено", "OK");
        await Navigation.PushAsync(new EventHistoryPage());
    }
}
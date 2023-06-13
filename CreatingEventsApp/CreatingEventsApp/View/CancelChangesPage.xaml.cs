namespace CreatingEventsApp.View;

public partial class CancelChangesPage : ContentPage
{
	public CancelChangesPage()
	{
		InitializeComponent();
	}

    private async void btnCancelChanges_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Успешно", "Изменения были отменены", "OK");
        await Navigation.PushAsync(new EventHistoryPage());
    }
}
using CreatingEventsApp.View;

namespace CreatingEventsApp;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();

		btnGroups.Clicked += LoadGroupsPage;
		btnEvents.Clicked += LoadEventsPage;
	}

	private async void LoadGroupsPage(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}

    private async void LoadEventsPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EventsPage());
    }

    private async void btnCheckEventHistory_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EventHistoryPage());
    }

    private async void btnChangePassword_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PasswordRecoveryPage());
    }

    private async void Exit_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}
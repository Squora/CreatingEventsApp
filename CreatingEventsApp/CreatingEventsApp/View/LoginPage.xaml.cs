namespace CreatingEventsApp.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
		if (eUsername.Text == "Admin" && ePassword.Text == "Admin")
		{
            await Navigation.PushAsync(new MainPage());
        }
		else
		{
            await DisplayAlert("Ошибка", "Неверно введены данные", "OK");
        }
    }

    private async void btnPasswordRecovery_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PasswordRecoveryPage());
    }

    private async void btnRegister_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}
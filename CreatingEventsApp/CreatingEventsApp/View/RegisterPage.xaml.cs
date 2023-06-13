namespace CreatingEventsApp.View;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private async void btnRegister_Clicked(object sender, EventArgs e)
    {
		if ((eName.Text != null && eSurname.Text != null && eEmail.Text != null && ePassword.Text != null
			&& eRepeatedPassword.Text != null) && (ePassword.Text == eRepeatedPassword.Text))
		{
            await DisplayAlert("Проверьте почту", "Дальнейшие инструкции отправлены вам на почту", "OK");
            await Navigation.PushAsync(new LoginPage());
        }
		else
		{
            await DisplayAlert("Ошибка", "Данные введены неверно!", "OK");
        }
    }
}
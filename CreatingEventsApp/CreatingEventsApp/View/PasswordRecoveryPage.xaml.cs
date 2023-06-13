namespace CreatingEventsApp.View;

public partial class PasswordRecoveryPage : ContentPage
{
	public PasswordRecoveryPage()
	{
		InitializeComponent();
	}

    private async void btnPasswordRecovery_Clicked(object sender, EventArgs e)
    {
		if (eLoginRecovery.Text != null)
		{
            await DisplayAlert("��������� �����", "���������� ���������� ���������� ��� �� �����", "OK");
            await Navigation.PushAsync(new LoginPage());
        }
		else
		{
            await DisplayAlert("������", "�������� �����", "OK");
        }
    }
}
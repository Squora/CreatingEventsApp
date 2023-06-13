using CreatingEventsApp.Models;
using Google.Cloud.Firestore;
using Microsoft.Extensions.Configuration;
using System.Collections;

namespace CreatingEventsApp.View;

public partial class GroupInfoPage : ContentPage
{
    public GroupInfoPage()
	{
		InitializeComponent();

        btnBack.Clicked += LoadMainPage;
    }

    private async void LoadMainPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
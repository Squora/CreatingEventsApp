using CreatingEventsApp.Models;
using CreatingEventsApp.View;
using Google.Cloud.Firestore;

namespace CreatingEventsApp;

public partial class MainPage : ContentPage
{
    public GroupInfoModel GroupInfo { get; set; }

    public MainPage()
    {
        InitializeComponent();

        btnEvents.Clicked += LoadEventsPage;
        btnProfile.Clicked += LoadProfilePage;

        GroupInfo = new GroupInfoModel
        {
            GroupNumber = "221-3710",
            Place = "ул. Павла Корчагина",
            LastLessionTime = "17:20",
            TelephoneNumber = "+7 (999) 999-99-99"
        };

        BindingContext = GroupInfo;
    }

    private async void GroupFrameTapped(object sender, TappedEventArgs args)
    {
        await Navigation.PushAsync(new GroupInfoPage());
    }

    private async void LoadEventsPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EventsPage());
    }

    private async void LoadProfilePage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfilePage());
    }
}


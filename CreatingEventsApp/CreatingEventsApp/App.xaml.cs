using CreatingEventsApp.View;

namespace CreatingEventsApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

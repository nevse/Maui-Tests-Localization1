namespace HumanaizerTests;
using System.Globalization;

public partial class App : Application
{
	public App()
	{
                CultureInfo.CurrentCulture = CultureInfo.CurrentUICulture = new CultureInfo("de");
		InitializeComponent();

		MainPage = new MainPage();
	}
}

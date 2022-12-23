namespace GaugeExample;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzgxMDMwQDMyMzAyZTMzMmUzMFpXcEJaQ0ZvanI4aDBaK042dDM2WDZSaHFYejByM1k4ZXBzaGI5ZnJrTWs9");
		InitializeComponent();

		MainPage = new AppShell();
	}
}

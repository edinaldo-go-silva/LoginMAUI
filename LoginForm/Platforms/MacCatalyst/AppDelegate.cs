using Foundation;

namespace RoteiroFiscalObra;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => RoteiroFiscalObra.CreateMauiApp();
}

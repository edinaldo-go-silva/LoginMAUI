using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace RoteiroFiscalObra;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => RoteiroFiscalObra.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}

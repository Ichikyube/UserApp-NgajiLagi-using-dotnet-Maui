using Microsoft.Maui.Controls.Compatibility.Hosting;
namespace Ngaji;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCompatibility()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("icomoon.ttf", "icomoon");
                fonts.AddFont("Nunito-Italic-VariableFont_wght.ttf", "NunitoItalic");
                fonts.AddFont("Nunito-VariableFont_wght.ttf", "Nunito");
                fonts.AddFont("Nunito-Black.ttf", "Nunito-black");
                fonts.AddFont("Nunito-ExtraBold.ttf", "Nunito-extrabold");
            })
            .ConfigureMauiHandlers(handlers =>
            {
                #if ANDROID
                    handlers.AddHandler(typeof(Shell), typeof(Ngaji.Platforms.Android.Renderers.CustomShellRenderer));
                #endif
            });
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("CleanEntry", (handler, view) =>
        {
            #if WINDOWS
                handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
            #elif IOSZ
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
            #endif
        });
        return builder.Build();
	}
}

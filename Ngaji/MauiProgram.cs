using Microsoft.Maui.Controls.Compatibility.Hosting;
using Microsoft.Maui.Platform;

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
                fonts.AddFont("Poppins-Medium.ttf", "Poppins-medium");
                fonts.AddFont("Poppins-SemiBold.ttf", "Poppins-semibold");
            })
            .ConfigureMauiHandlers(handlers =>
            {
                #if ANDROID
                    handlers.AddHandler(typeof(Shell), typeof(Ngaji.Platforms.Android.Renderers.CustomShellRenderer));
                #endif
            });
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("CleanEntry", (handler, view) =>
        {
            #if ANDROID
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
                handler.PlatformView.Text.PadLeft(24);
                handler.PlatformView.Left= 24;
#elif IOS || MACCATALYST
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
                handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
#elif WINDOWS
                handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
#endif
        });
        return builder.Build();
	}
}

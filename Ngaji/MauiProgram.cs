namespace Ngaji;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("Nunito-Italic-VariableFont_wght.ttf", "NunitoItalic");
                fonts.AddFont("Nunito-VariableFont_wght.ttf", "Nunito");
                fonts.AddFont("Nunito-Black.ttf", "Nunito-black");
            });

		return builder.Build();
	}
}

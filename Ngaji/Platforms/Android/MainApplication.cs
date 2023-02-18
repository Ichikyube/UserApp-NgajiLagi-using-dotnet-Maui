using Android.App;
using Android.Runtime;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using static Android.Icu.Text.CaseMap;

namespace Ngaji;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline",
        (h, v) => { 
            //Remove underline: 
            h.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid()); 
        });
        //Microsoft.Maui.Handlers.TabbedViewHandler.Mapper.AppendToMapping("MyCustomMargin", (h, v) =>
        //{
        //    h.PlatformView.
        //});
        return MauiProgram.CreateMauiApp();
        
    }
    
}

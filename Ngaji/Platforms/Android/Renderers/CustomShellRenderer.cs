using Android.Content;
using Android.Widget;
using Google.Android.Material.BottomNavigation;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using Ngaji;
using Ngaji.Platforms.Android.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: ExportRenderer(typeof(AppShell), typeof(CustomShellRenderer))]
namespace Ngaji.Platforms.Android.Renderers
{
    public class CustomShellRenderer : ShellRenderer
    {
        public CustomShellRenderer(Context context) : base(context)
        {
        }

        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new MyShellBottomNavViewAppearanceTracker();
        }
    }
}
public class MyShellBottomNavViewAppearanceTracker : IShellBottomNavViewAppearanceTracker
{
    public void Dispose()
    {
    }

    public void ResetAppearance(BottomNavigationView bottomView)
    {
    }

    public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
    {
        (bottomView.Parent as LinearLayout)?.SetBackgroundColor(Colors.White.ToAndroid());
        bottomView.SetBackgroundResource(Ngaji.Resource.Drawable.bottombackground);
    }
}

using Android.Content;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using Google.Android.Material.BottomAppBar;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.Tabs;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;
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
            return new MyShellBottomNavViewAppearanceTracker(this, shellItem);
        }

        protected override IShellTabLayoutAppearanceTracker CreateTabLayoutAppearanceTracker(ShellSection shellSection)
        {
            return new MyTabLayoutAppearanceTracker(this);
        }
    }
}
public class MyShellBottomNavViewAppearanceTracker : ShellBottomNavViewAppearanceTracker
{
    public MyShellBottomNavViewAppearanceTracker(IShellContext shellContext, ShellItem shellItem) : base(shellContext, shellItem)
    {
    }
    public new void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    public static void ResetAppearance()
    {
    }

    public override void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
    {
        base.SetAppearance(bottomView, appearance);
        bottomView.SetMinimumHeight(180);
        //bottomView.LayoutParameters.Height = 70;
       (bottomView.Parent as LinearLayout)?.SetBackgroundColor(Colors.White.ToAndroid());
        bottomView.SetBackgroundResource(Ngaji.Resource.Drawable.bottombackground);
        bottomView.SetForegroundGravity(GravityFlags.CenterVertical);
        bottomView.Elevation = 0;
        bottomView.Bottom = bottomView.Baseline;
        bottomView.LabelVisibilityMode = 0;
    }
}

public class MyTabLayoutAppearanceTracker : ShellTabLayoutAppearanceTracker
{
    public MyTabLayoutAppearanceTracker(IShellContext shellContext) : base(shellContext)
    {
    }

    public override void SetAppearance(TabLayout tabLayout, ShellAppearance appearance)
    {
        base.SetAppearance(tabLayout, appearance);
        tabLayout.SetElevation(0);
        tabLayout.SetForegroundGravity(GravityFlags.Bottom);
        var displayWidth = (int)Microsoft.Maui.Devices.DeviceDisplay.MainDisplayInfo.Width;
        for (int i = 0; i < tabLayout.TabCount; i++)
        {
            TabLayout.Tab tab = tabLayout.GetTabAt(i);
            if (tab.CustomView == null)
            {
                TextView textview = new(Android.App.Application.Context)
                {
                    Text = tabLayout.GetTabAt(i).Text,
                    TextSize = 20,
                    Typeface = Typeface.DefaultBold,
                    Gravity = GravityFlags.Bottom
                };
                textview.SetWidth(displayWidth / 2);
                tab.SetCustomView(textview);
            }
        }
    }
}
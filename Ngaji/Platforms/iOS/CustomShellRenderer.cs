using CoreAnimation;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using Ngaji.Platforms.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

[assembly: ExportRenderer(typeof(Ngaji.AppShell), typeof(CustomioShellRenderer))]
namespace Ngaji.Platforms.iOS
{
    class CustomioShellRenderer : ShellRenderer
    {
        protected override IShellTabBarAppearanceTracker CreateTabBarAppearanceTracker()
        {
            return new MyShellTabBarAppearanceTrancker();
        }
    }
}
class MyShellTabBarAppearanceTrancker : IShellTabBarAppearanceTracker
{
    public void Dispose()
    {

    }

    public void ResetAppearance(UITabBarController controller)
    {

    }

    public void SetAppearance(UITabBarController controller, ShellAppearance appearance)
    {

        UIBezierPath uIBezierPath = UIBezierPath.FromRoundedRect(controller.TabBar.Bounds, UIRectCorner.TopLeft | UIRectCorner.TopRight, new CoreGraphics.CGSize(30, 30));
        CAShapeLayer cAShapeLayer = new CAShapeLayer();
        cAShapeLayer.Frame = controller.TabBar.Bounds;
        cAShapeLayer.Path = uIBezierPath.CGPath;
        controller.TabBar.Layer.Mask = cAShapeLayer;
    }

    public void UpdateLayout(UITabBarController controller)
    {

    }
}
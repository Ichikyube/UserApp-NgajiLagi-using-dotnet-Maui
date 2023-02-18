using Ngaji.Pages.Auth;
using Ngaji.Pages.Mengaji;
using Ngaji.Pages.Order;

namespace Ngaji;

public partial class AppShell : Shell
{
   
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("login", typeof(Login));
        Routing.RegisterRoute("lupapassword", typeof(LupaPassword));
        Routing.RegisterRoute("ngajidetail", typeof(DetailPage));
        Routing.RegisterRoute("consultation", typeof(KonsultasiPage));
        Routing.RegisterRoute("catdetails", typeof(LoadingBacaanPage));
        Routing.RegisterRoute("ngajisession", typeof(SesiMengajiPage));
        Routing.RegisterRoute("BookConfirm", typeof(ConfirmPage));
        Routing.RegisterRoute("Discount", typeof(DiscountPage));
        Routing.RegisterRoute("paymentmethod", typeof(PaymentMethodPage));
    }
}

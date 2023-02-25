using Ngaji.Pages.Auth;
using Ngaji.Pages.Mengaji;
using Ngaji.Pages.Booking;
using Ngaji.Pages.Profile;

namespace Ngaji;

public partial class AppShell : Shell
{
   
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("login", typeof(Login));
        Routing.RegisterRoute("lupapassword", typeof(LupaPassword));
        Routing.RegisterRoute("gantipassword", typeof(GantiPassword));
        Routing.RegisterRoute("ngaji-detail", typeof(DetailPage));
        Routing.RegisterRoute("ngaji-consultation", typeof(KonsultasiPage));
        Routing.RegisterRoute("loadingbacaan", typeof(LoadingBacaanPage));
        Routing.RegisterRoute("loadingschedule", typeof(LoadingSchedulePage));
        Routing.RegisterRoute("ngaji-riwayat", typeof(RiwayatMengajiPage));
        Routing.RegisterRoute("ngaji-session", typeof(SesiMengajiPage));
        Routing.RegisterRoute("book-appointment", typeof(BookingPage));
        Routing.RegisterRoute("book-confirm", typeof(ConfirmPage));
        Routing.RegisterRoute("book-discount", typeof(DiscountPage));
        Routing.RegisterRoute("book-payment", typeof(PaymentMethodPage));
        Routing.RegisterRoute("userprofile", typeof(UserProfile));
        Routing.RegisterRoute("editprofile", typeof(EditProfile));
    }
}

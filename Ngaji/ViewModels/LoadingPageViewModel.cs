using Newtonsoft.Json;
using Ngaji.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ngaji.ViewModels
{
    public class LoadingPageViewModel
    {
        public LoadingPageViewModel() 
        {
            CheckUserLoginDetails();
        }

        private async void CheckUserLoginDetails()
        {

/* Unmerged change from project 'Ngaji (net6.0-windows10.0.19041.0)'
Before:
            string userDetailsStr = Preferences.Get(nameof(Models.UserModel), "");
After:
            string userDetailsStr = Preferences.Get(nameof(UserModel), "");
*/
            string userDetailsStr = Preferences.Get(nameof(Models.User.UserProfile), "");

            if (string.IsNullOrWhiteSpace(userDetailsStr))
            {
                await Shell.Current.GoToAsync($"//{nameof(Pages.Auth.Login)}");
            }
            else
            {
               // var userInfo = JsonConvert.DeserializeObject<UserBasicInfo>(UserDetailsStr);
                //App.UserDetails = userInfo;
                //AppShell.Current.FlyoutHeader = new FlyoutHeaderBehavior();
                await Shell.Current.GoToAsync($"//{nameof(LandingPage)}");
                //navigate to dashboard
            }
        }
        
    }
}

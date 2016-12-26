using LifeMasters.Core.Contracts.Services;
using LifeMasters.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeMasters.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            // Application setup code goes here
            //
            var userService = Mvx.Resolve<IUserDataService>();
            // TODO: determine if a login is necessary.
            //await userService.Login("mMouse", "1234");
            ShowViewModel<MainViewModel>(); // Navigate to the main view model.
        }
    }
}

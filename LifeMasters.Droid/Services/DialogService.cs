using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LifeMasters.Core.Contracts.Services;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;

namespace LifeMasters.Droid.Services
{
    public class DialogService : IDialogService
    {
        protected Activity CurrentActivity =>
            Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

        public Task ShowAlertAsync(string message, string title, string buttonText)
        {
            return Task.Run(() =>
            {
                Alert(message, title, buttonText);
            });
        }

        private void Alert(string message, string title, string buttonText)
        {
            Application.SynchronizationContext.Post(ignored =>
            {
                var builder = new AlertDialog.Builder(CurrentActivity);
                builder.SetIconAttribute(Android.Resource.Attribute.AlertDialogIcon);
                builder.SetTitle(title);
                builder.SetMessage(message);
                builder.SetPositiveButton(buttonText, delegate { });
                builder.Create().Show();
            }, null);
        }
    }
}
using LifeMasters.Core.Contracts.ViewModels;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Messenger;

namespace LifeMasters.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(IMvxMessenger messenger) : base(messenger)
        {
        }

        public void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }
    }
}

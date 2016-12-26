using LifeMasters.Core.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Messenger;

namespace LifeMasters.Core.ViewModels
{
    public class InstructionsViewModel : BaseViewModel
    {
        public InstructionsViewModel(IMvxMessenger messenger) : base(messenger)
        {
        }
    }
}

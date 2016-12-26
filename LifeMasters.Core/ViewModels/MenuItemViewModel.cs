using LifeMasters.Core.Contracts.ViewModels;
using LifeMasters.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Messenger;

namespace LifeMasters.Core.ViewModels
{
    public class MenuItemViewModel : BaseViewModel
    {
        private bool _isSelected;

        public MenuItemViewModel(IMvxMessenger messenger) : base(messenger)
        {
        }

        public string Title { get; set; }
        public Type ViewModelType { get; set; }
        public MenuOption Option { get; set; }
        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }
            set
            {
                _isSelected = value;
                RaisePropertyChanged(() => IsSelected);
            }
        }
    }
}

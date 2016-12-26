using LifeMasters.Core.Contracts.ViewModels;
using LifeMasters.Core.Utility;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using System;
using System.Collections.ObjectModel;

namespace LifeMasters.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public MvxCommand<MenuItemViewModel> MenuItemSelectCommand =>
            new MvxCommand<MenuItemViewModel>(OnMenuEntrySelect);
        public ObservableCollection<MenuItemViewModel> MenuItems { get; }

        public event EventHandler CloseMenu;

        public MenuViewModel(IMvxMessenger messenger) : base(messenger)
        {
            MenuItems = new ObservableCollection<MenuItemViewModel>();
            CreateMenuItems();
        }

        private void CreateMenuItems()
        {
            MenuItems.Add(new MenuItemViewModel(Messenger)
            {
                Title = "Instructions",
                ViewModelType = typeof(InstructionsViewModel),
                Option = MenuOption.Instructions,
                IsSelected = true
            });

            //MenuItems.Add(new MenuItemViewModel
            //{
            //    Title = "Settings",
            //    ViewModelType = typeof(SettingsViewModel),
            //    Option = MenuOption.Settings,
            //    IsSelected = false
            //});
        }

        private void OnMenuEntrySelect(MenuItemViewModel item)
        {
            ShowViewModel(item.ViewModelType);
            RaiseCloseMenu();
        }

        private void RaiseCloseMenu()
        {
            CloseMenu?.Invoke(this, EventArgs.Empty);
        }
    }
}
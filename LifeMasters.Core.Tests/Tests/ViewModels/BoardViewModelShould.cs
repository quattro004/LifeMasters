using LifeMasters.Core.Contracts.Services;
using LifeMasters.Core.ViewModels;
using Moq;
using MvvmCross.Plugins.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LifeMasters.Core.Tests.Tests.ViewModels
{
    public class BoardViewModelShould
    {
        [Fact]
        public async Task display_users_name()
        {
            var mockMessenger = new Mock<IMvxMessenger>();
            var mockBoardDataService = new Mock<IBoardDataService>();
            var mockDialogService = new Mock<IDialogService>();
            var boardViewModel = new BoardViewModel(mockMessenger.Object, mockBoardDataService.Object,
                mockDialogService.Object);

            //await boardViewModel.LoadBoard();
            // TODO: create a fake board view model and test the InitializeAsync method
        }
    }
}

using LifeMasters.Core.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Messenger;
using LifeMasters.Core.Contracts.Services;

namespace LifeMasters.Core.ViewModels
{
    public class BoardViewModel : BaseViewModel
    {
        private readonly IBoardDataService _boardDataService;
        private readonly IDialogService _dialogService;

        public BoardViewModel(IMvxMessenger messenger,
            IBoardDataService boardDataService,
            IDialogService dialogService) : base(messenger)
        {
            _boardDataService = boardDataService;
            _dialogService = dialogService;
        }

        internal Task LoadBoard()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Used to pass parameters from one view model to the next. Called by the MvvmCross framework.
        /// </summary>
        public void Init()
        {

        }

        public override async void Start()
        {
            base.Start();
            await ReloadDataAsync();
        }

        protected override Task InitializeAsync()
        {
            // TODO: perform board initialization.
            return base.InitializeAsync();
        }
        
        // When returning from tombstoning use the follow 3 methods.
        //public class SavedState
        //{
        //    public int JourneyId { get; set; }
        //}

        //public SavedState SaveState()
        //{
        //    MvxTrace.Trace("SaveState called");
        //    return new SavedState { JourneyId = _journeyId };
        //}

        //public void ReloadState(SavedState savedState)
        //{
        //    MvxTrace.Trace("ReloadState called with {0}",
        //        savedState.JourneyId);
        //    _journeyId = savedState.JourneyId;
        //}
    }
}

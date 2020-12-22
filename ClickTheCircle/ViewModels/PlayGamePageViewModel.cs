using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClickTheCircle.ViewModels
{
	public class PlayGamePageViewModel : ViewModelBase
	{
        public PlayGamePageViewModel(INavigationService navigationService):base(navigationService)
        {
            Title = "Good Luck!";

            YouLoseCommand = new DelegateCommand(YouLose);
            YouWinCommand = new DelegateCommand(YouWin);
        }

        private void YouWin()
        {
            Status = "You Win!";
        }

        private void YouLose()
        {
            Status = "You Lose!";
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { SetProperty(ref status, value); }
        }   

        public DelegateCommand YouWinCommand { get; set; }
        public DelegateCommand YouLoseCommand { get; set; }
    }
}

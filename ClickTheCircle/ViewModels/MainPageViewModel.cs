using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickTheCircle.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Click the Circle";
            PlayGameCommand = new DelegateCommand(PlayGame);
        }

        private void PlayGame()
        {
            NavigationService.NavigateAsync("PlayGame");
        }

        public DelegateCommand PlayGameCommand { get; set; }
    }
}

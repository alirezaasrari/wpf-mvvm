using hotel.Services;
using hotel.Stores;
using hotel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        private System.Windows.Navigation.NavigationService makeReservationNavigationService;

        public NavigateCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public NavigateCommand(System.Windows.Navigation.NavigationService makeReservationNavigationService)
        {
            this.makeReservationNavigationService = makeReservationNavigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
    }
}

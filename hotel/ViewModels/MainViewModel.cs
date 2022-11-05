using hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(Hotel hotel)
        {
            // CurrentViewModel = new MakeReservationViewModel(hotel);
            CurrentViewModel = new ReservationListingViewModel();
        }
    }
}

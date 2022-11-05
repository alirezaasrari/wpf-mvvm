using hotel.Commands;
using hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace hotel.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value;
            onPropertyChanged(nameof(Username));
            }
        }

        private int _roomNumber;
        public int RoomNumber
        {
            get { return _roomNumber; }
            set
            {
                _roomNumber = value;
                onPropertyChanged(nameof(RoomNumber));
            }
        }

        private int _floorNumber;
        public int FloorNumber
        {
            get { return _floorNumber; }
            set
            {
                _floorNumber = value;
                onPropertyChanged(nameof(FloorNumber));
            }
        }

        private DateTime _startTime = new DateTime(2021,1,1);
        public DateTime StartTime
        {
            get { return _startTime; }
            set
            {
                _startTime = value;
                onPropertyChanged(nameof(StartTime));
            }
        }

        private DateTime _endTime = new DateTime(2021, 1, 8);
        public DateTime EndTime
        {
            get { return _endTime; }
            set
            {
                _endTime = value;
                onPropertyChanged(nameof(EndTime));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel(Hotel hotel, Stores.NavigationStore navigationStore, Func<ReservationListingViewModel> createReservationViewModel)
        {
            SubmitCommand = new MakeReservationCommand(this,hotel);
            CancelCommand = new NavigateCommand(navigationStore, createReservationViewModel);
        }
    }
}

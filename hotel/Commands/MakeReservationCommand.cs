 using hotel.Exceptions;
using hotel.Models;
using hotel.Services;
using hotel.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace hotel.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;
        private readonly NavigationService reservationViewNavigationService;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel, NavigationService reservationViewNavigationService)
        {
            _hotel = hotel;
            this.reservationViewNavigationService = reservationViewNavigationService;
            _makeReservationViewModel = makeReservationViewModel;

            _makeReservationViewModel.PropertyChanged += onViewModelPropertyChanged;
        }

        private void onViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(MakeReservationViewModel.Username) ||
                e.PropertyName == nameof(MakeReservationViewModel.FloorNumber))
            {
                OnCanExecutedChanged(); 
            } 
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty( _makeReservationViewModel.Username) && _makeReservationViewModel.FloorNumber > 0 && base.CanExecute(parameter); 
        }
        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber,
                _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username,
                _makeReservationViewModel.StartTime,
                _makeReservationViewModel.EndTime
                );
            try
            {
                _hotel.MakeReservation(reservation);
                MessageBox.Show("successfully reserved room", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                reservationViewNavigationService.Navigate();
            }
            catch (ReservationConflictException)
            {

                MessageBox.Show("this room is already taken", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            } 
        }
       
    }
}

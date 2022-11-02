using hotel.Exceptions;
using hotel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace hotel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("azadi");

            try
            {
                hotel.MakeReservation(new Reservation(
                new RoomID(1, 3),
                "hilton",
                new DateTime(2000, 1, 3),
                new DateTime(2000, 1, 4)));

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    "hilton",
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 4)));
            }
            catch(ReservationConflictException ex)
            {

            }


     //       IEnumerable<Reservation> reservation = hotel.GetAllReservations("azadi");

            base.OnStartup(e);
        }
    }
}

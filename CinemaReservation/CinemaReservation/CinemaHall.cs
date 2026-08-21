using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation
{
    internal class CinemaHall
    {
        private string movieName;
        private int totalSeats;
        private int reservedSeats;

        public void CreateHall(string movieName, int totalSeats)
        {
            this.movieName = movieName;
            this.totalSeats = totalSeats;
        }
        public void ReserveSeat()
        {
            if (RemainingSeats() > 0)
            {
                reservedSeats++;
                Console.WriteLine("Resevation is succesfully made");
            }
            else Console.WriteLine("Sorry, we are full");
        }
        public void CancelReservation()
        {
            if (reservedSeats > 0)
            {
                reservedSeats--;
                Console.WriteLine("Resevation is succesfully canceled");
            }
            else Console.WriteLine("There is no resevation to cancel");
        }
        public int RemainingSeats()
        {
            return totalSeats - reservedSeats;
        }
        public void PrintHallInfo()
        {
            Console.WriteLine($"Filmin adi: {movieName}, Umumi oturacaq sayi: {totalSeats}, Rezervasiya olunan oturacaq sayi: {reservedSeats}, Bos oturacaq sayi: {RemainingSeats()}");
        }
    }
}

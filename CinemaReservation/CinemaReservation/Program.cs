namespace CinemaReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*test ai ile yazilib*/


            CinemaHall cinema = new CinemaHall();

            cinema.CreateHall("Spiderman:Brand New Home", 5);

            cinema.PrintHallInfo();

            cinema.ReserveSeat();
            cinema.ReserveSeat();

            cinema.PrintHallInfo();

            cinema.CancelReservation();

            cinema.PrintHallInfo();

            cinema.ReserveSeat();
            cinema.ReserveSeat();
            cinema.ReserveSeat();
            cinema.ReserveSeat();

            cinema.PrintHallInfo();

            cinema.ReserveSeat();

            cinema.CancelReservation();
            cinema.CancelReservation();
            cinema.CancelReservation();
            cinema.CancelReservation();
            cinema.CancelReservation();
            cinema.CancelReservation();

            cinema.PrintHallInfo();
        }
    }
}

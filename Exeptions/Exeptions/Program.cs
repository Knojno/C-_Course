using System;
using Exeptions.Entities;
using Exeptions.Entities.Exceptions;


namespace Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room Number");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation" + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro" + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error " + e.Message);
            }





















        }
    }
}

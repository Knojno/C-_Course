using System;
using Exeptions.Entities.Exceptions;


namespace Exeptions.Entities
{
    class Reservation
    {
        public int RommNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int rommNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("ERROR");
            }
            RommNumber = rommNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn< now || checkOut< now)
            {
                throw new DomainException(" ERROR ");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("ERROR");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room"
                + RommNumber
                + ", check-in"
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out"
                + CheckOut.ToString("dd/MM/yyyy")
                + Duration()
                + "nights";
        }
    }
}

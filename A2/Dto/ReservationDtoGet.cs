using A2.Models;
using System;
using System.Linq;

namespace A2.Dto
{
    public class ReservationDtoGet
    {
        public long Id { get; set; }

        public long Sum { get; set; }

        public string Location { get; set; }

        public DateTime AddedOn { get; set; }

        public Models.Currency Currency { get; set; }

        public Models.Type Type { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public bool Documents { get; set; }

        public int RemarksNumber { get; set; }

        public static ReservationDtoGet GetDtoFromReservation(Reservation reservation)
        {
            return new ReservationDtoGet
            {
                Id = reservation.Id,
                Sum = reservation.Sum,
                Location = reservation.Location,
                AddedOn = reservation.AddedOn,
                Currency = reservation.Currency,
                Type = reservation.Type,
                DepartureTime = reservation.DepartureTime,
                ArrivalTime = reservation.ArrivalTime,
                Documents = reservation.Documents,
                RemarksNumber = reservation.Remarks.Count
            };
        }
    }
}


using A2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2.Dto
{
    public class ReservationDtoDetail
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

        public IEnumerable<RemarksDtoDetail> Remarks { get; set; }


        public static ReservationDtoDetail GetDtoFromReservation(Reservation reservation)
        {
            return new ReservationDtoDetail
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
                Remarks = reservation.Remarks.Select(c => new RemarksDtoDetail()
                {
                    Content = c.Content,
                })

            };
        }
    }
}

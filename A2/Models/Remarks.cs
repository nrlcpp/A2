using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace A2.Models
{
    public enum Importance
    {
        hight,
        medium,
        lower
    }
    public class Remarks
    {
        public long Id { get; set; }
        public string Agent { get; set; }
        public string Content { get; set; }
        public Importance Importance { get; set; }
        public long ReservationId { get; set; }

        [JsonIgnore]
        public Reservation Reservation { get; set; }

    }
}

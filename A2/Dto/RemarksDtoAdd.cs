using A2.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2.Dto
{
    public enum Importance
    {
        hight,
        medium,
        lower
    }
    public class RemarksDtoAdd
    {
        public long Id { get; set; }
        public string Agent { get; set; }
        public string Content { get; set; }
        public Models.Importance Importance { get; set; }

        public static Remarks GetRemarksFromDto(long id, RemarksDtoAdd remarks)
        {
            return new Remarks
            {
                Id = remarks.Id,
                Agent = remarks.Agent,
                Content = remarks.Content,
                Importance = remarks.Importance,
                ReservationId = id,
            };
        }
    }

}

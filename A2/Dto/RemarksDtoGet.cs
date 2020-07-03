using A2.Models;

namespace A2.Dto
{
    public class RemarksDtoGet
    {
        public long Id { get; set; }
        public string Agent { get; set; }
        public string Content { get; set; }
        public Models.Importance Importance { get; set; }
        public long ReservationId { get; set; }

        public static RemarksDtoGet GetDtoFromRemarks(Remarks remarks)
        {
            return new RemarksDtoGet
            {
                Id = remarks.Id,
                Agent = remarks.Agent,
                Content = remarks.Content,
                Importance = remarks.Importance,
                ReservationId = remarks.ReservationId
            };
        }

    }



}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }
        [Required(ErrorMessage = "A Seat Name is required")]
        [MinLength(1)]
        public string Name { get; set; }
        public string SeatNumber { get; set; }
        [Range(1, 20)]
        public int Size { get; set; }

        public List<Reservation> Reservations { get; set; }
        public Section Sections { get; set; }

        [ForeignKey("PlaneFk")]
        public int PlaneFk { get; set; }
        public Plane Plane { get; set; }
    }
}

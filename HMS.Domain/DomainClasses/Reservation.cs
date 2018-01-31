using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.DomainClasses
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public string phone { get; set; }
       
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public Guest Guest { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.DomainClasses
{
    public class RoomManagment
    {
        [Key]
        public int id { get; set; }

       
        public ICollection<Room> RoomsAssigned { get; set; }
        public Reservation Reservation { get; set; }
        public ICollection<Guest> Guests { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.DomainClasses
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        /// <summary>
        /// Room type- Delux,Standard....
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// Status- Allocated-1 Reserved-2 Availabale=0
        /// </summary>
        public Int16 status { get; set; }
        /// <summary>
        /// Special intstruction to keeep the statsus of room
        /// </summary>
        public string Narration { get; set; }


        // public ICollection<Item> items { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.DomainClasses
{
    public class Guest
    {
        [Key]
        public int GuestID { get; set; }
        [MaxLength(15)]
        public string ContactNumber { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }

        /// <summary>
        /// Active or not- This should be set false at the checkout
        /// </summary>
        public bool Status { get; set; }
    }
}

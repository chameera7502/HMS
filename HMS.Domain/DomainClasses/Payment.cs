using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.DomainClasses
{
    public class Payment
    {
        [Key]
        public int id { get; set; }
        /// <summary>
        /// Advance paymnet=0 Balace payment=0
        /// </summary>
        public int PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal paymentAmount { get; set; }
        public decimal BalancePayment { get; set; }

        public Guest     Guest { get; set; }
       

    }
}

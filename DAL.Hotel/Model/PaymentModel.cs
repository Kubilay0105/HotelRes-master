using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel
{
    public class PaymentModel
    {
        public int PaymentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNo { get; set; }
        public string TransType { get; set; }
        public decimal Debt { get; set; }
        public decimal Credit { get; set; }
        public bool Status { get; set; }


    }
}

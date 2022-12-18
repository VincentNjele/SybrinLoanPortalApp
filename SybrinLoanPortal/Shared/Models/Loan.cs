using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SybrinLoanPortal.Shared.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Amount { get; set; }
        public double GrossAmount { get; set; }
        public double NetAmount { get; set; }
        public double FixedAmount { get; set; }
        public int PaymentPeriod { get; set; }
        public int Interest { get; set; }
        public int? ClientDocId { get; set; }
        public virtual ClientDoc ClientDoc { get; set; }
    }
}

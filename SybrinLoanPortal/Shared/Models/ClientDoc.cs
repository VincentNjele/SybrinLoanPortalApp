using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SybrinLoanPortal.Shared.Models
{
    public class ClientDoc
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }   
        public string CountryOfBirth { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public int? ProductTypeId { get; set; }
        
        public virtual ProductType? ProductType { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
    }
}

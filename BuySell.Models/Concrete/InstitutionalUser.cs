using BuySell.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell.Models.Concrete
{
    public class InstitutionalUser : BaseModel
    {
        public string? CorporateName { get; set; }
        public string? TaxAdministration { get; set; }
        public int TaxNumber { get; set; }
        public string? GSMNo { get; set; }
        public string? Address { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Price
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public float Amount { get; set; }
        public Currency Currency { get; set; }
        public DateTime TransactionDate { get; set; }
        public string PreviousOwner { get; set; }
        public string NewOwner { get; set; }
        public string Rank { get; set; }
        public Specification Specification { get; set; }
        // Navigation properties//
        public int SpecificationId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Loot
    {
        public int Id { get; set; }
        public string? label { get; set; }
        public Position? Position { get; set; }
        public Specification Specification { get; set; }
        public string Rank { get; set; }
        public List<Price>? Prices { get; set; }
        public int UserId { get; set; }
        public int PositionId { get; set; }
        public int SpecificationId { get; set; }
    }
}

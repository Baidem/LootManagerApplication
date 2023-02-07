using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public List<PersonType> Type { get; set; }

    }

}

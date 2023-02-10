using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PublicationGraphic : Book
    {
        public ICollection<Person> Drawers { get; set; }
        public ICollection<Person> Assistants { get; set; }
        public ICollection<Person> Colorists { get; set; }
    }
}

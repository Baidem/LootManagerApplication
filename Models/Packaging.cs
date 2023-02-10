using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;

namespace Models
{
    public class Packaging
    {
        public int Id { get; set; }
        public PackType Type { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
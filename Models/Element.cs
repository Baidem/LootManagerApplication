using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Element
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string? Label { get; set; }
        public Position? LootPosition { get; set; }
        public InfoSheet Specification { get; set; }
        public string Rank { get; set; }
        public ICollection<Image> ImageGallery { get; set; }
        public bool HavePackaging { get; set; }
        public Position? PackagingPosition { get; set; }
        public double CurrentPrice { get; set; }
        // Navigation properties //
        public int LootPositionId { get; set; }
        public int PackagingPositionId { get; set; }
        public int UserId { get; set; }
        public int SpecificationId { get; set; }
    }
}

namespace Models
{
    public class House
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Label { get; set; }
        public int Index { get; set; }
        // Navigation properties //
        public Family Family { get; set; }
        public int FamilyId { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
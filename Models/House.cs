namespace Models
{
    public class House
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Label { get; set; }
        public int Index { get; set; }
        // Navigation properties //
        public User User { get; set; }
        public int UserId { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
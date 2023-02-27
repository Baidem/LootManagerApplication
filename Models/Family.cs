namespace Models
{
    public class Family
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Navigation properties //
        public List<User> Users { get; set; }
        public List<House> Houses { get; set; }
    }
}
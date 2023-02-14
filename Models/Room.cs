namespace Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Label { get; set; }
        public int Index { get; set; }
        // Navigation properties //
        public House House { get; set; }
        public int HouseId { get; set; }
        public List<Storage> Storages { get; set; }
    }
}
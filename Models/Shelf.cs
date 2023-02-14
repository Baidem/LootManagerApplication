namespace Models
{
    public class Shelf
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Label { get; set; }
        public int Index { get; set; }
        // Navigation properties //
        public Storage Storage { get; set; }
        public int StorageId { get; set; }
        public List<Position> Positions { get; set; }

    }
}
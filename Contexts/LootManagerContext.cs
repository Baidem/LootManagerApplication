using Microsoft.EntityFrameworkCore;
using Models;

namespace Contexts
{
    public class LootManagerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Position> Positions  { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<InfoSheet> InfoSheets { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Simple> Simples { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookSeries> BookSeriesList { get; set; }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<ToySeries> ToySeriesList { get; set; }
        public DbSet<Packaging> Packagings { get; set; }
        public DbSet<Person> People { get; set; }
    }
}

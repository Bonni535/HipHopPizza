using Microsoft.EntityFrameworkCore;
using hip_hop_pizza.Models;
using System.Runtime.CompilerServices;


public class HipHopPizzaDbContext : DbContext
{
    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<User> Users { get; set; }

    public DbSet<OrderItem> OrderItems { get; set; }

    public HipHopPizzaDbContext(DbContextOptions<HipHopPizzaDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(new Item[]
        {
            new Item { Id = 1, Name = "Calzone", Price = 4 },
            new Item { Id = 2, Name = "Pizza Margherita", Price = 7 },
            new Item { Id = 3, Name = "Pizza Burrata and Sausage", Price = 9 },
            new Item { Id = 4, Name = "Pizza Sausage and Friarielli", Price = 9},
            new Item { Id = 5, Name = "Pizza Tuna, Onions and Gorgonzola", Price = 11},
            new Item { Id = 6, Name = "Tiramisu", Price = 5},
            new Item { Id = 7, Name = "Crepes with Nutella, Whipped Cream and Strawberries", Price = 6}
        });
        modelBuilder.Entity<Order>().HasData(new Order[]
        {
            new Order { Id = 1, CustomerName = "Order1", IsClosed = true, CustomerPhone = 1234567, CustomerEmail = "JdP@hotmail.com", Type = "Pick up", PaymentType = "Cash", Total = 46, Tip = 5, CloseOrderDate = new DateTime(2024, 02, 02), UserId = 1  },
            new Order { Id = 2, CustomerName = "Order2", IsClosed = false, CustomerPhone = 2345678, CustomerEmail = "PizzaPazza@gmail.com", Type = "Online", PaymentType = "Credit Card", Total = 52, Tip = 7, CloseOrderDate = new DateTime(2024, 04, 06), UserId = 2}
        });
        modelBuilder.Entity<User>().HasData(new User[]
        {
            new User { Id = 1, Name = "Pier", Uid = 1 },
            new User { Id = 2, Name = "Jean", Uid = 2 },
            new User { Id = 3, Name = "George", Uid = 3}
        });

        
    }
}
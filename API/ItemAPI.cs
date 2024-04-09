using hip_hop_pizza.Models;
//using hip_hop_pizza.Dtos;
using Microsoft.EntityFrameworkCore;
namespace HipHopPizza.API
{
    public class ItemAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/items", (HipHopPizzaDbContext db, int id) =>
            {
                return db.Items.ToList();
            });

            app.MapGet("/items/{id}", (HipHopPizzaDbContext db, int id) =>
            {
                var item = db.Items.Find(id);
                if (item == null) return Results.NotFound();
                return Results.Ok(item);
            });

            app.MapPost("/items", (HipHopPizzaDbContext db, Item item) =>
            {
                db.Items.Add(item);
                db.SaveChanges();
                return Results.Created($"/items/{item.Id}", item);
            });

            app.MapDelete("/items/{id}", (HipHopPizzaDbContext db, int id) =>
            {
                var item = db.Items.Find(id);
                if (item == null) return Results.NotFound();
                
                db.Items.Remove(item);
                db.SaveChanges();
                return Results.NoContent();

            });


        }
    }
}
using hip_hop_pizza.Models;
using hip_hop_pizza.Dtos;
using Microsoft.EntityFrameworkCore;
namespace HipHopPizza.API
{
    public class UserApi
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/checkuser/{uid}", (HipHopPizzaDbContext db, int uid) =>
            {
                var user = db.Users.Where(user => user.Uid == uid).ToList();

                if (uid == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(user);
                }
            });

            app.MapPost("/user", (HipHopPizzaDbContext db, User newUser) =>
            {
                db.Users.Add(newUser);
                db.SaveChanges();
                return Results.Created($"/user/{newUser.Id}", newUser);
            });
        }
    }
}
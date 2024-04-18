using hip_hop_pizza.Models;
// using hip_hop_pizza.Dtos;
using Microsoft.EntityFrameworkCore;
namespace HipHopPizza.API
{

    public class RevenueAPI
    {
        public static void Map(WebApplication app)
        {

            // Get Total Revenue
            app.MapGet("/revenue/total", (HipHopPizzaDbContext db) =>
             {
                 var totalRevenue = db.Orders.Sum(o => o.Total + o.Tip);

                 return Results.Ok(new { Total = totalRevenue });
             });
        }
    }
}
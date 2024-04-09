using hip_hop_pizza.Models;
using HipHopPizza.Dtos;
//using hip_hop_pizza.Dtos;
using Microsoft.EntityFrameworkCore;
namespace HipHopPizza.API
{
    public class OrderItemApi
    {
        public static void Map(WebApplication app)
        {
            app.MapPost("order/additem", async (HipHopPizzaDbContext _context, AddItemToOrderDto addItemToOrderDto) =>
            {
                Order order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == addItemToOrderDto.OrderId);

                Item item = await _context.Items.FirstOrDefaultAsync(x => x.Id == addItemToOrderDto.ItemId);
                OrderItem orderItem = new()
                {
                    Item = item,
                    Order = order
                };

                order.Items.Add(orderItem);

                await _context.SaveChangesAsync();

                return Results.Ok();
            });

            app.MapPost("/order/removeitem", async (HipHopPizzaDbContext _context, AddItemToOrderDto addItemToOrderDto) =>
            {
                Order order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == addItemToOrderDto.OrderId);

                Item item = await _context.Items.FirstOrDefaultAsync(x => x.Id == addItemToOrderDto.ItemId);

                OrderItem orderItem = await _context.OrderItems.FirstOrDefaultAsync(x => x.Item.Id == item.Id && x.Order.Id == order.Id);


                order.Items.Remove(orderItem);

                await _context.SaveChangesAsync();

                return Results.Ok();
            });
        }
    }

}


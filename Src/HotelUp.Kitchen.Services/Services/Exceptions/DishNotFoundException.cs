using HotelUp.Kitchen.Shared.Exceptions;

namespace HotelUp.Kitchen.Services.Services.Exceptions;

public class DishNotFoundException : NotFoundException
{
    public DishNotFoundException(string dishName) : base($"Dish with name: {dishName} not found.")
    {
    }
}
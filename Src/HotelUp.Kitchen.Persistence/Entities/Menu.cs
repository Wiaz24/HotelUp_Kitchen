﻿namespace HotelUp.Kitchen.Persistence.Entities;

public class Menu
{
    public required Cook Cook { get; init; }
    public required DateOnly ServingDate { get; init; }
    public required bool Published { get; set; } = false;
    public required List<Dish> Dishes { get; init; }
}
﻿namespace Tutorial4.Models;

public class Visit
{
    public int Id { get; set; }
    public DateTime DateOfVisit { get; set; }
    public Animal Animal { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
}
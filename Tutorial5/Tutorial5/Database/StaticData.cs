using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> Animals = new()
    {
        new Animal {Id = 1, Name = "Animal1", Category = "Cat", Weight = 4.1, FurColor = "Ginger"},
        new Animal {Id = 2, Name = "Animal2", Category = "Dog", Weight = 8.3, FurColor = "Black"},
        new Animal {Id = 3, Name = "Animal3", Category = "Bird", Weight = 0.9, FurColor = "Multicolor"}
    };
    
    public static List<Visit> Visits = new()
    {
        new Visit {Id = 1, Animal = Animals[0], DateOfVisit = DateTime.Today, Description = "Checkup", Price = 50.0},
        new Visit {Id = 2, Animal = Animals[1], DateOfVisit = DateTime.Today, Description = "Vaccination", Price = 100.0},
        new Visit {Id = 3, Animal = Animals[2], DateOfVisit = DateTime.Today, Description = "Surgery", Price = 200.0}
    };
}
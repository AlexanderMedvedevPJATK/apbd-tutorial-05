using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> Animals = new() {
        new Animal { Id = 1, Name = "Animal1", Category = "Cat", Weight = 4.1, FurColor = "Ginger"},
        new Animal { Id = 2, Name = "Animal2", Category = "Dog", Weight = 8.3, FurColor = "Black"},
        new Animal { Id = 3, Name = "Animal3", Category = "Bird", Weight = 0.9, FurColor = "Multicolor"}
    };
}
using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> animals = new()
    {
        new Animal {Category = "a",FirstName = "pes",FurColor = "white",Id = 1,Weight = 5},
        new Animal {Category = "b",FirstName = "kit",FurColor = "black",Id = 2,Weight = 3},
        new Animal {Category = "с",FirstName = "hom",FurColor = "grey",Id = 3,Weight = 1},
        
    };
    
    public static List<Visit> visits = new()
    {
        new Visit{animal = animals.First(a => a.Id == 1), date = new DateTime(2024,4,1),discription = "o_o", price = 45}
        
        
    };
    
    
    
}
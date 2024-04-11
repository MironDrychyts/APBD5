using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = StaticData.animals;   
        return Ok(animals);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);

        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        StaticData.animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);

        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found and cant be deleted");
        }

        StaticData.animals.Remove(animal);
        return NoContent();
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animalToDel = StaticData.animals.FirstOrDefault(a => a.Id == id);

        if (animalToDel == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        StaticData.animals.Remove(animalToDel);
        StaticData.animals.Add(animal);
        return NoContent();

    }
    


}
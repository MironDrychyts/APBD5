using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
[Route("[controller]")]
public class VisitsController : ControllerBase
{

    [HttpGet]
    public IActionResult GetVisits()
    {
        var visits = StaticData.visits;   
        return Ok(visits);
    }
    
    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        StaticData.visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }

    
    


}
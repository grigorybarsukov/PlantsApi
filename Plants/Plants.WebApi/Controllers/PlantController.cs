using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Plants.Domain;

namespace Plants.WebApi.Controllers;

[Route("api/v1/plants")]
public class PlantController : Controller
{
    private Fixture Fixture;

    public PlantController()
    {
        Fixture = new Fixture();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Fixture.CreateMany<Plant>(10));
    }
    
    [HttpGet("{id:guid}")]
    public IActionResult Get(Guid id)
    {
        return Ok(Fixture.Create<Plant>());
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plants.Persistent;

namespace Plants.WebApi.Controllers;

[Route("api/v1/plants")]
public class PlantController : Controller
{
    private readonly PlantsDbContext dbContext;

    public PlantController(PlantsDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await dbContext.Plants.AsQueryable().ToListAsync();
        return Ok(data);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var plant = await dbContext.Plants.Where(p=>p.Id==id).SingleOrDefaultAsync();
        return Ok(plant);
    }
}
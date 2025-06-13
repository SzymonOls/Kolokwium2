using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers;

[ApiController]
[Route("api/nurseries")]
public class NurseryController : ControllerBase
{
    private readonly IDbService _dbService;

    public NurseryController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{id}/batches")]
    public async Task<IActionResult> GetPurchases(int id)
    {
        try
        {
            var order = await _dbService.GetNursery(id);
            return Ok(order);
        }
        catch (NullReferenceException)
        {
            return NotFound();
        }
    }
}
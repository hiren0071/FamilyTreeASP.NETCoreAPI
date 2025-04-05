using FamilyTreeAPI.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FamilyTreeController : ControllerBase
{
    private const string ValidClientId = "YourValidClientId";

    [HttpGet("{familyTreeId}")]
    public IActionResult GetFamilyTreePeople(Guid familyTreeId)
    {
        // Check for the presence of the custom header
        if (!Request.Headers.ContainsKey("x-client-id"))
        {
            return BadRequest("x-client-id header is required");
        }

        var clientId = Request.Headers["x-client-id"].ToString();
        if (clientId != ValidClientId)
        {
            return Unauthorized("Invalid x-client-id");
        }

        var familyTrees = FamilyTreeService.GetFamilyTrees();
        var familyTree = familyTrees.FirstOrDefault(ft => ft.Id == familyTreeId);

        if (familyTree == null)
        {
            return NotFound("Family tree not found");
        }

        var peopleList = familyTree.People.Select(p => new
        {
            Id = p.Id,
            NameAndLifeSpan = $"{p.FullName} - {p.Lifespan}"
        }).ToList();

        return Ok(peopleList);
    }
}

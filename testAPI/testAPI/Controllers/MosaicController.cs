using Microsoft.AspNetCore.Mvc;
using testAPI.Contracts.Mosaic;
using Newtonsoft.Json;

namespace testAPI.Controllers;

[ApiController]
[Route("mosaic")]
public class MosaicController : ControllerBase
{
  [HttpPost("/access")]
  public IActionResult CreateAccess(CreateAcess access)
  {

    return Ok(access);
  }
}
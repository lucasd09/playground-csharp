using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Mosaic.Models.Ftm04100;

[ApiController]
[Route("api/[controller]")]
public class MosaicController : ControllerBase
{
    private readonly ILogger<MosaicController> _logger;
    private readonly AppDbContext _dbContext;

    public MosaicController(ILogger<MosaicController> logger, AppDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Ftm04100 acesso)
    {
        try
        {
            _dbContext.Ftm04100.Add(acesso);
            await _dbContext.SaveChangesAsync();
            return Ok("Dados salvos com sucesso!");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao salvar os dados no banco de dados.");
            return StatusCode(500, "Erro interno do servidor " + ex);
        }
    }
}

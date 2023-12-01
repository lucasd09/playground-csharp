using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using Mosaic.Models.Ftm04100;

[ApiController]
[Route("api/[controller]")]
public class MosaicController : ControllerBase
{
    private readonly ILogger<MosaicController> _logger;
    private readonly Ftm04100Repository _ftm04100Repository;

    public MosaicController(ILogger<MosaicController> logger, Ftm04100Repository ftm04100Repository)
    {
        _logger = logger;
        _ftm04100Repository = ftm04100Repository;
    }

    [HttpPost]
    public IActionResult Post([FromBody] Ftm04100 acesso)
    {
    try
    {
        _ftm04100Repository.Insert(acesso);
        return Ok("Dados salvos com sucesso!");
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Erro ao salvar os dados no banco de dados.");
        return StatusCode(500, "Erro interno do servidor " + ex);
    }
}

}

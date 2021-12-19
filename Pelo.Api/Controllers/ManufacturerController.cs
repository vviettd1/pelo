using Microsoft.AspNetCore.Mvc;
using Pelo.Common.Database.DbObjects;
using Pelo.Common.Database.Interfaces;

namespace Pelo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ManufacturerController : ControllerBase
{
    private readonly ILogger<ManufacturerController> _logger;
    private readonly IReadManufacturerRepository _readManufacturerRepository;

    public ManufacturerController(ILogger<ManufacturerController> logger,
        IReadManufacturerRepository readManufacturerRepository)
    {
        _logger = logger;
        _readManufacturerRepository = readManufacturerRepository;
    }

    [HttpGet(Name = "Get All Manufacturers")]
    public async Task<IEnumerable<Manufacturer>> GetAll()
    {
        return await _readManufacturerRepository.GetAll();
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniCRM.Application.DTOs;
using MiniCRM.Application.Interfaces;
using System.Security.Claims;

[ApiController]
[Route("api/company")]
[Authorize]
public class CompanyController : ControllerBase
{
    private readonly ICompanyService _companyService;

    public CompanyController(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCompanyDto dto)
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        await _companyService.CreateCompanyAsync(userId, dto);
        return Ok();
    }
}

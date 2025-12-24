using Microsoft.EntityFrameworkCore;
using MiniCRM.Application.DTOs;
using MiniCRM.Application.Interfaces;
using MiniCRM.Domain.Entities;
using MiniCRM.Infrastructure.Data;
namespace MiniCRM.Infrastructure.Services;


public class CompanyService : ICompanyService
{
    private readonly MiniCrmDbContext _db;

    public CompanyService(MiniCrmDbContext db)
    {
        _db = db;
    }

    public async Task CreateCompanyAsync(Guid userId, CreateCompanyDto dto)
    {
        var user = await _db.Users.FindAsync(userId);
        if (user == null) throw new Exception("User not found");

        var company = new Company
        {
            Name = dto.Name
        };

        user.Company = company;

        _db.Companies.Add(company);
        await _db.SaveChangesAsync();
    }
}

using MiniCRM.Application.DTOs;

namespace MiniCRM.Application.Interfaces;

public interface ICompanyService
{
    Task CreateCompanyAsync(Guid userId, CreateCompanyDto dto);
}

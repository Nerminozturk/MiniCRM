using Microsoft.EntityFrameworkCore;
using MiniCRM.Domain.Entities;

namespace MiniCRM.Infrastructure.Data;

public class MiniCrmDbContext : DbContext
{
    public MiniCrmDbContext(DbContextOptions<MiniCrmDbContext> options)
        : base(options) { }

    public DbSet<Company> Companies => Set<Company>();
    public DbSet<User> Users => Set<User>();


}

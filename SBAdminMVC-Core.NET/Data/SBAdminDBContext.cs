using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SBAdminMVC_Core.NET.Models;

namespace SBAdminMVC_Core.NET.Data
{
    public class SBAdminDBContext : DbContext
    {
        public SBAdminDBContext(DbContextOptions<SBAdminDBContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
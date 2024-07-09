using CAAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CAAPI.Data
{
    public class ApplicationDataBd : DbContext
    {
        public ApplicationDataBd(DbContextOptions<ApplicationDataBd> options)
    : base(options)
        {
        }

        public DbSet<Contact> contact { get; set; } = null!;
    }
}

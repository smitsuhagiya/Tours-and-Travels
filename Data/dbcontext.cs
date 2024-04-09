using Microsoft.EntityFrameworkCore;
using SeeIndia.Models;

namespace Seeindia.Data
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> s) : base(s)
        {

        }

        public DbSet<UserModel> Users { get; set; }

        

    }
}

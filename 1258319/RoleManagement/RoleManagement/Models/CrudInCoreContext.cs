using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace RoleManagement.Models
{
    public class CrudInCoreContext: IdentityDbContext
    {
        public CrudInCoreContext(DbContextOptions<CrudInCoreContext> options) : base(options)
        {

        }

        //public DbSet<Student> Students { get; set; }

        //public DbSet<Product> Products { get; set; }
    }
}

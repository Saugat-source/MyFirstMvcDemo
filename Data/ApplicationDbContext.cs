using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvcdemo.Models;

namespace mvcdemo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
       public DbSet<Pet> pets{get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

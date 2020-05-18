using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHero.Models;

namespace SuperHero.Data
{
    public class SuperHeroDbContext : IdentityDbContext
    
        {
            public SuperHeroDbContext(DbContextOptions<SuperHeroDbContext> options)
                : base(options)
            {

            }

            public DbSet<SuperHeroDbContext> SuperHeroes { get; set; }
        }
    }

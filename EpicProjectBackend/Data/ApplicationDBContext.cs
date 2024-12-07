using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpicProjectBackend.Models;

// veliki objekt koji nam specificira koju tablicu želimo(ili koji dio želimo) iz baze podataka
namespace EpicProjectBackend.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

            
        }
        //trenutno radimo bazu podataka kroz ORM(Entity Framework) i koristimo SQL Server
        public DbSet<User> User { get; set; }
    }
}

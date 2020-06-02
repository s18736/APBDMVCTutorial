using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBDMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace APBDMVC.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
           : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}

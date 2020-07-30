using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment4.Models;

namespace Assignment4.Data
{
    public class AppDbMovieContext : DbContext
    {
        public AppDbMovieContext (DbContextOptions<AppDbMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment4.Models.Movie> Movie { get; set; }
    }
}

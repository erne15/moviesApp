using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviesApp.Models;

namespace moviesApp.Data
{
    public class moviesAppContext : DbContext
    {
        public moviesAppContext (DbContextOptions<moviesAppContext> options)
            : base(options)
        {
        }

        public DbSet<moviesApp.Models.Movie> Movie { get; set; } = default!;
    }
}

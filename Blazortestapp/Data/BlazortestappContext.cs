using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blazortestapp.Models;

namespace Blazortestapp.Data
{
    public class BlazortestappContext : DbContext
    {
        public BlazortestappContext (DbContextOptions<BlazortestappContext> options)
            : base(options)
        {
        }

        public DbSet<Blazortestapp.Models.Movie> Movie { get; set; } = default!;
    }
}

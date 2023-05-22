using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Liikunta.Models;

namespace Liikunta.Data
{
    public class LiikuntaContext : DbContext
    {
        public LiikuntaContext (DbContextOptions<LiikuntaContext> options)
            : base(options)
        {
        }

        public DbSet<Liikunta.Models.Route> Route { get; set; } = default!;
    }
}

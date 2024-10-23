using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LigaPro.Models;

namespace LigaPro.Data
{
    public class LigaProContext : DbContext
    {
        public LigaProContext (DbContextOptions<LigaProContext> options)
            : base(options)
        {
        }

        public DbSet<LigaPro.Models.Jugadores> Jugadores { get; set; } = default!;
        public DbSet<LigaPro.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<LigaPro.Models.Equipo> Equipo { get; set; } = default!;
    }
}

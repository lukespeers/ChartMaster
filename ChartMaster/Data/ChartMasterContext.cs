using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChartMaster.Models;

namespace ChartMaster.Data
{
    public class ChartMasterContext : DbContext
    {
        public ChartMasterContext (DbContextOptions<ChartMasterContext> options)
            : base(options)
        {
        }

        public DbSet<Song> Song { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().ToTable("Song");
        }

    }
}

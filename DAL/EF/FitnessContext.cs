using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Gebruiker;
using Domain.Workout;

namespace DAL.EF
{
    internal class FitnessContext : DbContext
    {
        public FitnessContext()
            : base("debugConn")
        {
            Database.SetInitializer<FitnessContext>(new FitnessInitialiser());
        }

        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Oefening> Oefeningen { get; set; }
        public DbSet<Statistiek> Statistieken { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Gebruiker;
using System.Data.Entity;

namespace DAL
{
    public class GebruikerRepo : IGebruikerRepo
    {
        private EF.FitnessContext ctx;

        public GebruikerRepo()
        {
            ctx = new EF.FitnessContext();
        }

        public Gebruiker FindGebruikerOnId(int id)
        {
            return ctx.Gebruikers.Include(x => x.Workouts).Single(x => x.GebruikerId == id);
        }

        public void UpdateGebruiker(Gebruiker gebruiker)
        {
            ctx.Entry(gebruiker).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}

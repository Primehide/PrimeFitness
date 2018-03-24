using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Workout;
using System.Data.Entity;

namespace DAL
{
    public class WorkoutRepo : IWorkoutRepo
    {
        private EF.FitnessContext ctx;

        public WorkoutRepo()
        {
            ctx = new EF.FitnessContext();
        }

        public List<PersonaliseerdeWorkout> AllePersonaliseerdeWorkouts()
        {
            return ctx.Workouts.OfType<PersonaliseerdeWorkout>().Include(x => x.Gebruiker).ToList();
        }

        public List<Workout> AlleWorkouts()
        {
            return ctx.Workouts.ToList();
        }

        public void RemoveWorkout(int id)
        {
            Workout w = ctx.Workouts.Find(id);
            ctx.Entry(w).State = EntityState.Deleted;
            ctx.SaveChanges();
        }
    }
}

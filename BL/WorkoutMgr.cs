using System.Collections.Generic;
using DAL;
using Domain.Workout;
using System.Linq;
using System.Data.Entity;

namespace BL
{
    public class WorkoutMgr : Interfaces.IWorkoutMgr
    {
        private IWorkoutRepo repo;

        public WorkoutMgr()
        {
            repo = new WorkoutRepo();
        }

        public List<StandaardWorkout> AlleStandaardWorkouts()
        {
            return AlleWorkouts().OfType<StandaardWorkout>().ToList();
        }

        public List<Workout> AlleWorkouts()
        {
            return repo.AlleWorkouts();
        }

        public List<PersonaliseerdeWorkout> AllPersonalWorkoutsOnGebruiker(int gebruikersId)
        {
            return repo.AllePersonaliseerdeWorkouts().Where(x => x.Gebruiker.GebruikerId == gebruikersId).ToList();
        }

        public StandaardWorkout FindStandaardWorkoutOnId(int id)
        {
            return AlleStandaardWorkouts().Find(x => x.WorkoutId == id);
        }

        public void RemoveWorkout(int id)
        {
            repo.RemoveWorkout(id);
        }
    }
}

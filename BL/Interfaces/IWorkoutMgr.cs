using Domain.Workout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IWorkoutMgr
    {
        List<Workout> AlleWorkouts();
        List<StandaardWorkout> AlleStandaardWorkouts();
        StandaardWorkout FindStandaardWorkoutOnId(int id);
        List<PersonaliseerdeWorkout> AllPersonalWorkoutsOnGebruiker(int gebruikersId);
        void RemoveWorkout(int id);
    }
}

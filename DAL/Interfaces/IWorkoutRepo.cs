using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Workout;

namespace DAL
{
    public interface IWorkoutRepo
    {
        List<Workout> AlleWorkouts();
        List<PersonaliseerdeWorkout> AllePersonaliseerdeWorkouts();
        void RemoveWorkout(int id);
    }
}

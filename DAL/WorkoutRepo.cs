using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WorkoutRepo : IWorkoutRepo
    {
        private EF.FitnessContext ctx;

        public WorkoutRepo()
        {
            ctx = new EF.FitnessContext();
        }
    }
}

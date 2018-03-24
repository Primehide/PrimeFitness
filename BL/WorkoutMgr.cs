using DAL;

namespace BL
{
    public class WorkoutMgr : Interfaces.IWorkoutMgr
    {
        private IWorkoutRepo repo;

        public WorkoutMgr()
        {
            repo = new WorkoutRepo();
        }
    }
}

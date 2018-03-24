using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Workout
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public string Naam { get; set; }
        public Enum.WorkoutType Type { get; set; }
        public List<Oefening> Oefeningen { get; set; }
    }
}

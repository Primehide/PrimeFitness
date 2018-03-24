using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Workout
{
    public class Statistiek
    {
        public int StatistiekId { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public double Gewicht { get; set; }
        public double Volume { get; set; }
    }
}

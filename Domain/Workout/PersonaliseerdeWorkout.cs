using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Workout
{
    public class PersonaliseerdeWorkout : Workout
    {
        public Gebruiker.Gebruiker Gebruiker { get; set; }
    }
}

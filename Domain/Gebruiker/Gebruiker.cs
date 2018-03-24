using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Gebruiker
{
    public class Gebruiker
    {
        public int GebruikerId { get; set; }
        public string Naam { get; set; }
        public List<Vriend> Vrienden { get; set; }
        public Agenda Agenda { get; set; }
        public List<Tip> Tips { get; set; }
        public List<Workout.Oefening> GepersonaliseerdeOefeningen { get; set; }
        public List<Workout.PersonaliseerdeWorkout> Workouts { get; set; }
        public List<Duel> Duels { get; set; }
    }
}

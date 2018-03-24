using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Workout;

namespace PrimeFitness.Models
{
    public class AddWorkoutViewModel
    {
        public List<StandaardWorkout> StandaardWorkouts { get; set; }
        public List<PersonaliseerdeWorkout> WorkoutsHuidigeGebruiker { get; set; }
    }
}
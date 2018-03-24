using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Gebruiker;
using Domain.Workout;

namespace DAL.EF
{
    internal class FitnessInitialiser : DropCreateDatabaseIfModelChanges<FitnessContext>
    {
        protected override void Seed(FitnessContext context)
        {
            Gebruiker gebruiker1 = new Gebruiker()
            {
                Naam = "Sander"
            };

            Workout StandaardWorkout1 = new StandaardWorkout()
            {
                Oefeningen = new List<Oefening>(),
                Naam = "Standaardworkout 1"
            };

            Oefening StandaardOefening1 = new Oefening()
            {
                Naam = "Bench Press",
                BodyPart = Domain.Enum.BodyPart.CHEST
            };

            Oefening StandaardOefening2 = new Oefening()
            {
                Naam = "Romanian Deadlift",
                BodyPart = Domain.Enum.BodyPart.LEGS
            };

            StandaardWorkout1.Oefeningen.Add(StandaardOefening1);
            StandaardWorkout1.Oefeningen.Add(StandaardOefening2);

            context.Gebruikers.Add(gebruiker1);
            context.Workouts.Add(StandaardWorkout1);
            context.Oefeningen.Add(StandaardOefening1);
            context.Oefeningen.Add(StandaardOefening2);

            base.Seed(context);
        }
    }
}

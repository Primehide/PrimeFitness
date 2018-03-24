using BL;
using Domain.Gebruiker;
using Domain.Workout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeFitness.Controllers
{
    public class GebruikerController : Controller
    {
        // GET: Gebruiker
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddWorkout(int GebruikersId, int WorkoutId)
        {
            GebruikerMgr gebruikerMgr = new GebruikerMgr();
            WorkoutMgr workoutMgr = new WorkoutMgr();

            Gebruiker gebruiker = gebruikerMgr.FindGebruikerOnId(GebruikersId);
            StandaardWorkout standaardWorkout = workoutMgr.FindStandaardWorkoutOnId(WorkoutId);

            PersonaliseerdeWorkout personaliseerdeWorkout = new PersonaliseerdeWorkout()
            {
                Naam = standaardWorkout.Naam,
                Oefeningen = standaardWorkout.Oefeningen
            };

            try
            {
                gebruiker.Workouts.Add(personaliseerdeWorkout);
            } catch (NullReferenceException)
            {
                gebruiker.Workouts = new List<PersonaliseerdeWorkout>();
                gebruiker.Workouts.Add(personaliseerdeWorkout);
            }

            gebruikerMgr.UpdateGebruiker(gebruiker);

            return RedirectToAction("Index","Home");
        }

        public ActionResult RemoveWorkout(int GebruikersId, int WorkoutId)
        {
            GebruikerMgr gebruikerMgr = new GebruikerMgr();
            WorkoutMgr workoutMgr = new WorkoutMgr();

            Gebruiker gebruiker = gebruikerMgr.FindGebruikerOnId(GebruikersId);
            workoutMgr.RemoveWorkout(WorkoutId);

            return RedirectToAction("Index", "Home");
        }
    }
}
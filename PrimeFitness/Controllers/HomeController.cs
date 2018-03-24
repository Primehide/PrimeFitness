using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;
using Domain.Workout;
using Domain.Gebruiker;
using PrimeFitness.Models;

namespace PrimeFitness.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WorkoutMgr workoutMgr = new WorkoutMgr();
            GebruikerMgr gebruikerMgr = new GebruikerMgr();
            return View();
        }

        [HttpGet]
        public ActionResult AddWorkout()
        {
            WorkoutMgr workoutMgr = new WorkoutMgr();
            GebruikerMgr gebruikerMgr = new GebruikerMgr();
            AddWorkoutViewModel model = new AddWorkoutViewModel();

            model.StandaardWorkouts = workoutMgr.AlleStandaardWorkouts();
            model.WorkoutsHuidigeGebruiker = workoutMgr.AllPersonalWorkoutsOnGebruiker(1);

            return View(model);
        }
    }
}
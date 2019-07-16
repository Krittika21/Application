using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {
        private WebApplication1Context _DbContext;
        public static int testId;
        //public static int userId;
        public MainController(WebApplication1Context DbContext)
        {
            _DbContext = DbContext;
        }
//for the list of tests
        public IActionResult Index()
        {
            var lists = _DbContext.TestTypeMapping.Include(s => s.TestDetail).ThenInclude(s=>s.UserTests).Include(s => s.TestTypes);
            return View(lists);
        }
//for adding new test results to the list             
        public IActionResult CreateTest()
        {
            var test = _DbContext.TestType.AsEnumerable();
            return View(test);
        }
   
        public async Task<IActionResult> CreateNewTest([FromForm]CreateTestViewModel createTestView)
        {
            TestDetails testDetails = new TestDetails();
            TestTypeMapping typeMapping = new TestTypeMapping();
            var Map = _DbContext.TestType.Where(s => s.TestName == createTestView.TestType).FirstOrDefault();

            testDetails.Date = createTestView.TestDate;
            _DbContext.TestDetails.Add(testDetails);

            typeMapping.TestId = testDetails.ID;
            typeMapping.TestTypeId = Map.ID;
            _DbContext.TestTypeMapping.Add(typeMapping);
            await _DbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
//For the list of athletes
        public IActionResult CTAthletes(int id)
        {
            testId = id;
            var date = _DbContext.TestDetails.Where(s => s.ID == id).Select(s => s.Date);
            var name = _DbContext.TestTypeMapping.Where(s => s.TestId == id).Select(s => s.TestTypes.TestName);
            var athlete = _DbContext.UserTestMapping.Include(s => s.TestDetail).ThenInclude(s => s.TestTypes).Include(s=>s.Users).Where(s => s.TestId == id);

            ViewBag.Date = date.Single();
            ViewBag.Name = name.Single();
            
            return View(athlete);
        }
        public async Task<IActionResult> AthletesList([FromForm]AthletesViewModel athletesViewModel)
        {
            var users = _DbContext.User.Where(s => s.Name == athletesViewModel.AName);
            UserTestMapping userTestMapping = new UserTestMapping();
            TestDetails testDetails = new TestDetails();
            TestTypeMapping typeMapping = new TestTypeMapping();
            
            typeMapping.TestId = testDetails.ID;
            _DbContext.UserTestMapping.Add(userTestMapping);
            await _DbContext.SaveChangesAsync();
            
            return Redirect("CTAthletes");
        }
//Adding new athletes to the list
        public IActionResult AddAthlete(int id)
        {
            var player = _DbContext.User.AsEnumerable();
            return View(player);
        }
        public async Task<IActionResult> NewAthlete([FromForm]AthletesViewModel athletesViewModel)
        {
            UserTestMapping userTest = new UserTestMapping();
            //var NewA = _DbContext.User.Where(s => s.ID == athletesViewModel.UserId).Select(s => s.Name);
            var NewA = _DbContext.User.Where(s => s.Name == athletesViewModel.AName).Select(s => s.ID);
                                  
            userTest.UserId = NewA.Single();
                       
            userTest.TestId = testId;
            userTest.CTDistance = athletesViewModel.CTDistance;

            _DbContext.UserTestMapping.Add(userTest);

            await _DbContext.SaveChangesAsync();
            return RedirectToAction("CTAthletes");
        }
        private String CalculateFitness()
        {
            UserTestMapping userTest = new UserTestMapping();
            if (userTest.CTDistance < 1000)
            {
                userTest.FitnessRating = "Below Average";
            }
            else if (userTest.CTDistance > 1000 && userTest.CTDistance < 2000)
            {
                userTest.FitnessRating = "Average";
            }
            else if (userTest.CTDistance > 2000 && userTest.CTDistance < 3500)
            {
                userTest.FitnessRating = "Good";
            }
            else
            {
                userTest.FitnessRating = "Very Good";
            }
            return userTest.FitnessRating;
        }
    }
}
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
        private WebApplication1Context _dbContext;
        public static int testId;
        //public static int userId;
        public MainController(WebApplication1Context dbContext)
        {
            _dbContext = dbContext;
        }
//for the list of tests
        public IActionResult Index()
        {
            var lists = _dbContext.TestTypeMapping.Include(s => s.TestDetail).ThenInclude(s=>s.UserTests).Include(s => s.TestTypes);
            return View(lists);
        }
//for adding new test results to the list             
        public IActionResult CreateTest()
        {
            var test = _dbContext.TestType.AsEnumerable();
            return View(test);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewTest([FromForm]CreateTestViewModel createTestView)
        {
            TestDetails testDetails = new TestDetails();
            TestTypeMapping typeMapping = new TestTypeMapping();
            var Map = _dbContext.TestType.Where(s => s.TestName == createTestView.TestType).FirstOrDefault();

            testDetails.Date = createTestView.TestDate;
            _dbContext.TestDetails.Add(testDetails);

            typeMapping.TestId = testDetails.ID;
            typeMapping.TestTypeId = Map.ID;
            _dbContext.TestTypeMapping.Add(typeMapping);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
//For the list of athletes
        public IActionResult TestAthleteDetails(int id)
        {
            testId = id;
            var date = _dbContext.TestDetails.Where(s => s.ID == id).Select(s => s.Date);
            var name = _dbContext.TestTypeMapping.Where(s => s.TestId == id).Select(s => s.TestTypes.TestName);
            var athlete = _dbContext.UserTestMapping.Include(s => s.TestDetail).ThenInclude(s => s.TestTypes).Include(s=>s.Users).Where(s => s.TestId == id);

            ViewBag.Date = date.Single();
            ViewBag.Name = name.Single(); 
            
            return View(athlete);
        }
        [HttpPost]
        public async Task<IActionResult> AthletesList([FromForm]AthletesViewModel athletesViewModel)
        {
            var users = _dbContext.User.Where(s => s.Name == athletesViewModel.AName);
            UserTestMapping userTestMapping = new UserTestMapping();
            TestDetails testDetails = new TestDetails();
            TestTypeMapping typeMapping = new TestTypeMapping();
            
            typeMapping.TestId = testDetails.ID;
            _dbContext.UserTestMapping.Add(userTestMapping);
            await _dbContext.SaveChangesAsync();
            
            return RedirectToAction("TestAthleteDetails", new { id = testId });
        }
        //Adding new athletes to the list
        // GET: 
        public IActionResult AddAthlete()
        {
            var name = _dbContext.TestTypeMapping.Where(s => s.TestId ==testId).Select(s => s.TestTypes.TestName);
            var player = _dbContext.User.AsEnumerable();

            ViewBag.Name = name.Single();

            return View(player);
        }
        [HttpPost]
        public async Task<IActionResult> NewAthlete([FromForm]AthletesViewModel athletesViewModel)
        {
            UserTestMapping userTest = new UserTestMapping();
            //var NewA = _dbContext.User.Where(s => s.ID == athletesViewModel.UserId).Select(s => s.Name);
            var NewA = _dbContext.User.Where(s => s.Name == athletesViewModel.AName).Select(s => s.ID).First();
                                  
            userTest.UserId = NewA;

            if (athletesViewModel.CTDistance != null)
            {
               userTest.FitnessRating = CalculateFitness(athletesViewModel.CTDistance);
            }

            userTest.TestId = testId;
            userTest.CTDistance = athletesViewModel.CTDistance;
            //userTest.FitnessRating = CalculateFitness(athletesViewModel.CTDistance);
            userTest.STTime = athletesViewModel.STTime;

            _dbContext.UserTestMapping.Add(userTest);

            await _dbContext.SaveChangesAsync();
            return RedirectToAction("TestAthleteDetails", new { id = testId });
        }
//method to calculate the fitness rating
        private String CalculateFitness(double? distance)
        {
            string fitness;
            //var userTest = _dbContext.UserTestMapping.Where(x=>x.ID == id).Single();
            if (distance < 1000)
            {
                fitness = "Below Average";
            }
            else if (distance > 1000 && distance < 2000)
            {
                fitness = "Average";
            }
            else if (distance > 2000 && distance < 3500)
            {
                fitness = "Good";
            }
            else
            {
                fitness = "Very Good";
            }
            return fitness;
        }
        // GET: Main/Delete/5
        public IActionResult Delete(int id)
        {
            var delTest = _dbContext.TestTypeMapping.Where(s => s.ID == testId).Include(s => s.TestDetail).Single();
            return View(delTest);
        }
       //[HttpDelete]
       public IActionResult DeleteTest(int id)
        {
            var obj = _dbContext.TestTypeMapping.Where(s => s.TestId == testId).Single();
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        // GET: Main/TestAthleteDetails/Edit/5
        public IActionResult Edit(int id)
        {
            var model = _dbContext.UserTestMapping.Where(s => s.TestId == testId && s.UserId == id).Include(s => s.Users).SingleOrDefault();
            return View(model);
        }

        // PUT: Main/TestAthleteDetails/PutEdit/5
       // [HttpPut]
        public IActionResult PutEdit([FromForm] UserTestMapping userTestMapping)
        {
             var obj = _dbContext.UserTestMapping.Where(s => s.UserId == userTestMapping.UserId && s.TestId == userTestMapping.TestId).First();
            if (userTestMapping.CTDistance != null)
            {
                obj.CTDistance = userTestMapping.CTDistance;
            }
            else if (userTestMapping.STTime != null) {
                obj.STTime = userTestMapping.STTime;
            }

            _dbContext.UserTestMapping.Update(obj);
            _dbContext.SaveChanges();
            return RedirectToAction("TestAthleteDetails", new { id = testId });
        }
        //GET : Delete Athlete
        public IActionResult DeleteAthlete(int id)
        {
            var delAthlete = _dbContext.UserTestMapping.Where(s => s.ID == id).Include(s => s.Users).Single();
            return View(delAthlete);
        }
        //[HttpDelete]
        public IActionResult RemoveAthlete(int id)
        {
            var obj = _dbContext.UserTestMapping.Where(s => s.TestId == testId && s.UserId == id).First();
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
           return RedirectToAction("TestAthleteDetails", new { id = testId });
        }
    }
}
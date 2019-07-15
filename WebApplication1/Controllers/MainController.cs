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
//Fot the list of athletes
        public IActionResult CTAthletes(int id)
        {
            testId = id;
            var date = _DbContext.TestDetails.Where(s => s.ID == id).Select(s => s.Date).Single();
            var name = _DbContext.TestTypeMapping.Where(s => s.TestId == id).Select(s => s.TestTypes.TestName).Single();
            var athlete = _DbContext.UserTestMapping.Include(s => s.TestDetail).ThenInclude(s => s.TestTypes).Where(s => s.TestId == id);

            ViewBag.Date = date;
            ViewBag.Name = name;
            
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
        public async Task<IActionResult> NewAthlete([FromForm]UserTestMapping userTestMapping)
        {
            UserTestMapping userTest = new UserTestMapping();
            User user = new User();
            var NewA = _DbContext.User.Where(s => s.Name == ).FirstOrDefault();
            await _DbContext.SaveChangesAsync();
            return View();
        }
    }
}
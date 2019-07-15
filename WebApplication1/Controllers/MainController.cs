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

        public MainController(WebApplication1Context DbContext)
        {
            _DbContext = DbContext;
        }
        public IActionResult Index()
        {
            var lists = _DbContext.TestTypeMapping.Include(s => s.TestDetail).ThenInclude(s=>s.UserTests).Include(s => s.TestTypes);
            return View(lists);
        }
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

        public IActionResult CTAthletes()
        {
            var athlete = _DbContext.UserTestMapping.Include(s => s.TestDetail).ThenInclude(s => s.TestTypes);
            return View(athlete);
        }
        public IActionResult AthletesList([FromForm]AthletesViewModel athletesViewModel)
        {
            User users = new User();
            UserTestMapping userTestMapping = new UserTestMapping();
            TestDetails testDetails = new TestDetails();
            TestTypeMapping typeMapping = new TestTypeMapping();
            var fit = 

            userTestMapping.UserId = users.ID;
            userTestMapping.TestId = testDetails.ID;
            
            return View();
        }
    }
}
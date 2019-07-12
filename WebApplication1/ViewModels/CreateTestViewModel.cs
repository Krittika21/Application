using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class CreateTestViewModel
    {
        public TestType TestType { get; set; }
        public TestDetails TestDetails { get; set; }
    }
}

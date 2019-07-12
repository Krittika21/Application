using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TestDetails
    {
        [Key]
        public int ID { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<UserTestMapping> UserTests { get; set; }

        public TestTypeMapping TestTypes { get; set; }
    }
}

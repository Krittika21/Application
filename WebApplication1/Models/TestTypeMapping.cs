using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TestTypeMapping
    {
        public int ID { get; set; }
        public int TestTypeId { get; set; }
        public int TestId { get; set; }

        [ForeignKey("TestTypeId")]
        public virtual TestType TestTypes { get; set; }
        [ForeignKey("TestId")]
        public virtual TestDetails TestDetail { get; set; }
    }
}

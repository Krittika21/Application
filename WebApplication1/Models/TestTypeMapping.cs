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

        [ForeignKey("ID")]
        public virtual TestType TestTestId { get; set; }
        [ForeignKey("ID")]
        public virtual TestDetails TestId { get; set; }
    }
}

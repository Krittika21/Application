using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserTestMapping
    {
        public int ID { get; set; }
        public double CTDistance { get; set; }
        public double STTime { get; set; }
        public string FitnessRating { get; set; }

        public int TestId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("TestId")]
        public virtual TestDetails TestDetail { get; set; }
        [ForeignKey("UserId")]
        public virtual User Users { get; set; }
    }
}

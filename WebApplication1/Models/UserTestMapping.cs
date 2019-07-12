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

        [ForeignKey("ID")]
        public virtual TestDetails TestId { get; set; }
        [ForeignKey("ID")]
        public virtual User UserId { get; set; }
    }
}

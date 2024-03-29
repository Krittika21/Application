﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TestType
    {
        [Key]
        public int ID { get; set; }
        public string TestName { get; set; }

        public virtual ICollection<TestTypeMapping> TestTypes { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string DescriptionOfTask { get; set; }
        public DateTime DueDate { get; set; }
        public int PriorityLevel { get; set; }
        public Student Student { get; set; }




    }
}
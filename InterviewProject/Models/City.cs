﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class City
    {
        [Key]
        public int City_Id { get; set; }
        public string City_Name { get; set; }

        public int Country_Id { get; set; }
        public Country Country { get; set; }
    }
}

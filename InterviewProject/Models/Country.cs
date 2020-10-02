using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class Country
    {
        [Key]
        public int Country_Id { get; set; }
        public string Country_Name { get; set; }

        public Product Product { get; set; }
        public List<City> Cities { get; set; }
    }
}

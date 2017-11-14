using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBarney.Models
{
    public class Syllabus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }

        public ICollection<Day> Days { get; set; }
    }
}
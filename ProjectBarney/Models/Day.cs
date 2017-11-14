using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBarney.Models
{
    public class Day
    {
        public int Id { get; set; }
        public int SyllabusId { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Topics { get; set; }
        public string Labs { get; set; }
        public string NextClass { get; set; }

        public Syllabus Syllabus { get; set; }
    }
}
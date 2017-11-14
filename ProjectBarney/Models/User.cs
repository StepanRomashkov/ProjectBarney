using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBarney.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int SyllabusId { get; set; }

        public Syllabus Syllabus { get; set; }

    }
}
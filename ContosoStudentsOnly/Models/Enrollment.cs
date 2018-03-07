using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoStudentsOnly.Models
{
    public enum Grades
    {
        A,B,C,D,F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grades Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}

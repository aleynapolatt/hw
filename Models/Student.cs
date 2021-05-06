using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw.Models
{

    public class Student
    {
        public Student()
             {
            CreationDate =DateTime.Today;
            LastUpdateDate=DateTime.Now;
            }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentDepartment { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }


    }
}


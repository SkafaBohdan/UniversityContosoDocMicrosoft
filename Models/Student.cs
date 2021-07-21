using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityContosoDocMicrosoft.Models
{
    public class Student : Person
    {
            [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
      
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

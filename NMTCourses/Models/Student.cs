using System.ComponentModel.DataAnnotations;

namespace NMTCourses.Models
{
	public class Student
	{
		public int ID { get; set; }
        [Display(Name = "Ім'я")]
        public string FirstName { get; set; }
        [Display(Name = "Прізвище")]
        public string LastName { get; set; }
		public string Email { get; set; }

		// Navigation property for many-to-many relationship

	}

}

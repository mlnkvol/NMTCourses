using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace NMTCourses.Models
{
	public class Teacher
	{
		public int ID { get; set; }
        [Display(Name = "Ім'я")]
        public string FirstName { get; set; }
        [Display(Name = "Прізвище")]
        public string LastName { get; set; }
        [Display(Name = "Про себе")]
        public string Bio { get; set; }
		public string Email { get; set; }

        [Display(Name = "Фото")]
        public string? PhotoUrl { get; set; }


    }
}
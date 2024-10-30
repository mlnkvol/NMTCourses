using System.ComponentModel.DataAnnotations;

namespace NMTCourses.Models
{
	public class Category
	{
		public int ID { get; set; }
        [Required(ErrorMessage = "Будь ласка, введіть назву категорії")]
        [Display(Name = "Назва категорії")]
        public string Name { get; set; }

		// Navigation property

	}
}
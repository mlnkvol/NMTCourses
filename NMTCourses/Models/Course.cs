using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NMTCourses.Models
{
	public class Course
	{
		public int ID { get; set; }
        [Display(Name = "Назва курсу")]
        public string Title { get; set; }
        [Display(Name = "Опис курсу")]
        public string Description { get; set; }
        [Display(Name = "Дата та час старту")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Дата та час завершення")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Пробний конспект курсу")]
        public string? FileUrl { get; set; }
        [Display(Name = "Викладач")]
        public int TeacherID { get; set; }
        [Display(Name = "Викладач")]
        public Teacher? Teacher { get; set; }
        [Display(Name = "Категорія")]
        public int CategoryID { get; set; }
        [Display(Name = "Категорія")]
        public Category? Category { get; set; }

	}
}
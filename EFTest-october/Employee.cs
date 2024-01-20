using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest_october
{
	internal class Employee
	{
		[Key]
		public int ID { get; set; }

		[MaxLength(50)]
		public string Name { get; set; } = "";

		[Required]
		public string? Surname { get; set; }

		[ForeignKey(nameof(Department))]
		public int? DepartmentID { get; set; } // Foreign key

		public Department? Department { get; set; } // Navigation property

		public List<Profession> professions { get; set;} = new();
	}
}
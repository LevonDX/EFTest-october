using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest_october
{
	class Profession
	{
		public int ID { get; set; }
		public string Name { get; set; } = "";
		public string? Description { get; set; }

		public List<Employee> Employees { get; set; } = new();
	}
}

using EFTest_october.Context;

namespace EFTest_october
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using EmployeeDBContext context = new EmployeeDBContext();

			Employee employee = new Employee
			{
				Name = "John",
				Surname = "Doe",

				Department = new Department
				{
					Name = "IT",
					Description = "Information Technology"
				}
			};

			context.Employees.Add(employee);
			context.SaveChanges();
		}
	}
}
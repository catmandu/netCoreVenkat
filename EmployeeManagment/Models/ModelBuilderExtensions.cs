using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Mary",
                   Department = Dept.IT,
                   Email = "mary@domain.com"
               },
               new Employee
               {
                   Id = 2,
                   Name = "John",
                   Department = Dept.HR,
                   Email = "john@domain.com"
               });
        }
    }
}

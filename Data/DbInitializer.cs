using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fast_Food.Models;

namespace Fast_Food.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FoodContext context)
        {
            
            if (context.Employees.Any())
            {
                return;
            }
            Employee[] employees = new Employee[]
                {
                new Employee {FirstName = "Ivan", LastName = "Petrov" , PhoneNumber = "123-123-120" , Role = Roles.Manager , Salary = 100000M},
                new Employee {FirstName = "Petar", LastName = "Ivanov" , PhoneNumber = "123-123-121" , Role = Roles.AssistantManager , Salary = 40000M},
                new Employee {FirstName = "Anton", LastName = "Dimov" , PhoneNumber = "123-123-122" , Role = Roles.Cashier , Salary = 10000M},
                };
            context.Employees.AddRange(employees);
            context.SaveChanges();
           
        }

    }
}

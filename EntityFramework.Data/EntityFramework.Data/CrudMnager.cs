using EntityFramework.Data.DemoEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public class CrudManager
    {
        private DemoDbContext demoDbContext;
        public CrudManager()
        {
            demoDbContext = new DemoDbContext();
        }
        public List<Employee> GetAllEmployees()
        {
            var employee = demoDbContext.Employees.ToList();
            return employee;
        }
        public void Insert(Employee employee)
        {
            demoDbContext.Employees.Add(employee);
            demoDbContext.SaveChanges();
        }
        public void Update(int employeeId, Employee modifiedEmployee)
        {
            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId).FirstOrDefault();
            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }

            employee.Name = modifiedEmployee.Name;
            employee.Address = modifiedEmployee.Address;
            demoDbContext.Employees.Update(employee);
            demoDbContext.SaveChanges();
        }
        public void Delete(int employeeId)
        {
            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId).FirstOrDefault();
            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }
            demoDbContext.Employees.Remove(employee);
            demoDbContext.SaveChanges();
        }
    }
}

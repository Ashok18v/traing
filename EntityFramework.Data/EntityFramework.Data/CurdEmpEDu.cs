using EntityFramework.Data.DemoEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
  public class CurdEmpEDu
    {
        private DemoDbContext demodb;
        public CurdEmpEDu()
        {
            demodb = new DemoDbContext();
        }
        public List<EmployeeEducation> GetAllEmpEdu()
        {
            var emp_Education = demodb.EmpEducation.ToList();
            return emp_Education;
        }
        public void InsertEmployeeAndEducation(Employee employee, List<EmployeeEducation> educationList)
        {
            var objEmployee = new Employee
            {
                Name = employee.Name,
                Address = employee.Address,
                EducationList = educationList

            };

            demodb.Employees.Add(objEmployee);
            demodb.SaveChanges();
        }
        public void insert(EmployeeEducation emp_Education)
        {
            demodb.EmpEducation.Add(emp_Education);
            demodb.SaveChanges();
        }
        public void update(int id, EmployeeEducation updateempedu)
        {
            var result = demodb.EmpEducation.Where(x => x.ID == id).FirstOrDefault();
            if (result == null)
            {
                throw new Exception($"Employee with ID:{id} Not Found");
            }
            result.CourseName = updateempedu.CourseName;
            result.UniversityName = updateempedu.UniversityName;
            result.PassingYear = updateempedu.PassingYear;
            result.MarksPercentage = updateempedu.MarksPercentage;
            demodb.EmpEducation.Update(result);
            demodb.SaveChanges();
        }
        public void delete(int id)
        {
            var res=demodb.EmpEducation.Where(x => x.ID == id).FirstOrDefault();
            if (res == null)
            {
                throw new Exception($"Employee with ID:{id} Not Found");
            }
            demodb.EmpEducation.Remove(res);
            demodb.SaveChanges();
        }
    }
}

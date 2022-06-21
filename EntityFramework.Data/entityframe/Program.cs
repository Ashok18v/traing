using EntityFramework.Data;
using EntityFramework.Data.DemoEntities;

namespace entityframe
{
    public class Program
    {
        static void Main(string[] args)
        {
            CurdClass curdClass = new CurdClass();
            var result = new Teacher
            {
                Name = "Ashok"
            };
            curdClass.insert(new ClassRoom { Name="First",Teacher=result});
            //CrudManager obj = new CrudManager();

            //Console.WriteLine("Adding a new Employee");
            //obj.Insert(new Employee { Name = "Ashok", Address = "Vijayawada" });
            //obj.Insert(new Employee { Name = "Sai", Address = "Guntur" });
            //PrintAllEmployees();
            //obj.Update(3, new Employee { Name = "Venkat", Address = "Banglore" });
            //PrintAllEmployees();
            //obj.Delete(3);
            //PrintAllEmployees();
         //   CurdEmpEDu curdEmpEDu = new CurdEmpEDu();
            //Employee employee = (new Employee { Name = "Ashok", Address = "Vijayawada" });
            //curdEmpEDu.insert(new EmployeeEducation { CourseName = "Ece", UniversityName = "Lbrce", PassingYear = 2016, MarksPercentage = 90,Employee= employee});
            //curdEmpEDu.update(1, new EmployeeEducation { CourseName = "Cse", UniversityName = "Lbrce", PassingYear = 2019, MarksPercentage = 80 });
            //curdEmpEDu.delete(1);
            //List<EmployeeEducation> educationList = new List<EmployeeEducation>();
            //educationList.Add(new EmployeeEducation { CourseName = "BCA", UniversityName = "Manipal", MarksPercentage = 80, PassingYear = 2020 });
            //educationList.Add(new EmployeeEducation { CourseName = "MCA", UniversityName = "Manipal", MarksPercentage = 75, PassingYear = 2022 });

            //curdEmpEDu.InsertEmployeeAndEducation(new Employee { Name = "Manish", Address = "Pune" }, educationList);
        }

        //private static void PrintAllEmployees()
        //{
        //    Console.WriteLine("Printing all Employees");
        //    CrudManager obj = new CrudManager();
        //    foreach (Employee employee in obj.GetAllEmployees())
        //    {
        //        Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
        //    }
       // }
    }
}

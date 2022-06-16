using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankdbEntities bankdbEntities = new BankdbEntities();
           //var data= bankdbEntities.Customers.ToList();
           // foreach (var item in data)
           // {
           //     Console.WriteLine(item.CustId);
           //     Console.WriteLine(item.CustName);
           //     Console.WriteLine(item.Email);
           //     Console.WriteLine(item.Mobile);
           //     Console.WriteLine(item.CustAddress);
           // }
            Employe employe=new Employe();
            employe.Emp_Id = 9;
            employe.Emp_Name = "Harsha";
            employe.Emp_dept = "IT";
            employe.Mobile_Number = 8887779691;
            employe.Emp_Address = "Vizag";
            bankdbEntities.Employes.Add(employe);
            bankdbEntities.SaveChanges();
                }
    }
}

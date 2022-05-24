using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionProject
{

    public class Program
    {
        public static void Main(String[] args)
        {
            Employee E1 = new Employee
            {
                EmployeeName = "Pranali",
                EmployeeId = 33,
                EmployeeNumber = 8689864045,
                EmployeeType = EmpType.Permanent,
                EmployeeDateOfBirth = new DateTime(1998,08,21) //Convert.ToDateTime("08/21/1998")
            };
            Employee E2 = new Employee
            {
                EmployeeName = "Pranaya",
                EmployeeId = 03,
                EmployeeNumber = 9930109078,
                EmployeeType = EmpType.intern,
                EmployeeDateOfBirth = Convert.ToDateTime("10/10/2000")
            };
            Employee E3 = new Employee
            {
                EmployeeName = "Manali",
                EmployeeId = 07,
                EmployeeNumber = 7039390762,
                EmployeeType = EmpType.PartTime,
                EmployeeDateOfBirth = Convert.ToDateTime("10 /15/1995")
            };
            Employee E4 = new Employee
            {
                EmployeeName = "Vrushali",
                EmployeeId = 63,
                EmployeeNumber = 9823456788,
                EmployeeType = EmpType.FullTime,
                EmployeeDateOfBirth = Convert.ToDateTime("2/10/1997")
            };
            Employee E5 = new Employee
            {
                EmployeeName = "Chaitrali",
                EmployeeId = 47,
                EmployeeNumber = 8836764045,
                EmployeeType = EmpType.Permanent,
                EmployeeDateOfBirth = Convert.ToDateTime("7/05/1996")
            };
            Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();
            Employees.Add(E1.EmployeeId, E1);
            Employees.Add(E2.EmployeeId, E2);
            Employees.Add(E3.EmployeeId, E3);
            Employees.Add(E4.EmployeeId, E4);
            Employees.Add(E5.EmployeeId, E5);
            Console.WriteLine("The Employee Details are:");
            foreach (var k in Employees.Values)
            {
                Console.WriteLine("Id: {0}  \nName: {1} \nNumber: {2}  \nEmployee Type: {3}  \nDOB: {4} ", k.EmployeeId, k.EmployeeName, k.EmployeeNumber, k.EmployeeType, k.EmployeeDateOfBirth);
                Console.WriteLine("----------------------------------------------------------------------------");
            }
            Console.WriteLine(Employees.ContainsKey(33));
            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
            Console.Read();
        }

    }

}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



using FrostSteelCorporation.CSharpTest.CSharpTest6.HRAdministrationAPI;





namespace FrostSteelCorporation.CSharpTest.CSharpTest6
{
    public class CSharpTest69
    {
        public static decimal totalSalaries = 0;
        


        public void SchoolAdministration()
        {
            


          
            
            List<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);
            foreach (IEmployee employee in employees) {

                totalSalaries += employee.Salary;
            
            

            }


             string TotalSalaries = $"Total Annual Salaries(including bonus):{totalSalaries}";
             Console.WriteLine(TotalSalaries);



        }


        public static void SeedData(List<IEmployee> employees) {

            IEmployee teacher1 = new Teacher
            {
                ID = 1,
                FirstName = "Bob",
                LastName="Fisher",
                Salary=40000,

            };
            employees.Add(teacher1);
            IEmployee teacher2 = new Teacher { 
            
            ID = 2,
            FirstName ="Jenny",
            LastName="Thomas",
            Salary =40000,
             
            
            
            };
            employees.Add(teacher2);
            IEmployee headofDepartment = new HeadofDepartment
            {

                ID = 3,
                FirstName = "Brenda",
                LastName = "Mullins",
                Salary = 50000,



            };
            employees.Add(headofDepartment); 
            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {

                ID = 4,
                FirstName = "Devlin",
                LastName = "Brown",
                Salary = 60000,



            };
            employees.Add(deputyHeadMaster);
            IEmployee headofMaster = new HeadofMaster
            {

                ID = 5,
                FirstName = "Damian",
                LastName = "Jones",
                Salary = 80000,



            };
            employees.Add(headofMaster);






        }





    }

    public class Teacher : EmployeeBase {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }
    public class HeadofDepartment : EmployeeBase {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }
    public class DeputyHeadMaster : EmployeeBase {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }

    public class HeadofMaster : EmployeeBase {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }






}

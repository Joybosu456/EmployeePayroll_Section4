using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollOpration
{
    public class EmployeePayrollOperation
    {
        List<EmployeeDetails>employeedetails=new List<EmployeeDetails>();
        public void addEmployeePayroll(List<EmployeeDetails>listemployeedetails)
        {
            listemployeedetails.ForEach(employeeData =>
            {
                Console.WriteLine(employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine(employeeData.EmployeeName);

           
            });
            Console.WriteLine(this.employeedetails.ToString());
            
             
        }
        private abstract void addEmployeePayroll(EmployeeDetails emp)
        {
            employeedetails.Add(emp);
        }
        public void addEmployeePayrollwiththread(List<EmployeeDetails>listemployeedetails)
        {
            listemployeedetails.ForEach(employeedata =>
           {
               Task tread = new Task(() =>
                 {
                     Console.WriteLine(employeedata.EmployeeName);
                     this.addEmployeePayroll(listemployeedetails);
                     Console.WriteLine(employeedata.EmployeeName);

                 });
               tread.Start();
           });
            Console.WriteLine(this.employeedetails.ToString());
        }
    }
}

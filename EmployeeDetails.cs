using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollOpration
{
    public class EmployeeDetails
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public char Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public EmployeeDetails(int employeeid,string employeename,string phonenumber,
            string address,string department,char gender,double basicpay,
            double deduction,double taxablepay,double tax,double netpay,string city,
            string country)
        {
            this.EmployeeId = employeeid;
            this.EmployeeName= employeename;
            this.PhoneNumber = phonenumber;
            this.Address = address;
            this.Department = department;
            this.Gender = gender;
            this.BasicPay = basicpay;
            this.Deduction = deduction;
            this.TaxablePay = taxablepay;
            this.Tax= tax;
            //this.NetPay = netpay;
            this.City = city;
            this.Country= country;
        }

    }
}

using System;
using System.Collections.Generic;
namespace EmployeePayrollOpration
{
    class Programm
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to my Employee Payroll opration Program");
            //List<EmployeeDetails>employeeDetails=new List<EmployeeDetails>();
            //employeeDetails.Add(new EmployeeDetails(1, "Joy", "58745689", "Kolkata", "Engineer", 'M', 457258.00, 250.00, 350.00, 300.00, "Kolkata","India")),
            //employeeDetails.Add(new EmployeeDetails(1, "Joy", "58745689", "Kolkata", "Engineer", 'M', 457258.00, 250.00, 350.00, 300.00, "Kolkata", "India")),
            //employeeDetails.Add(new EmployeeDetails(1, "Joy", "58745689", "Kolkata", "Engineer", 'M', 457258.00, 250.00, 350.00, 300.00, "Kolkata", "India")),
            //employeeDetails.Add(new EmployeeDetails(1, "Joy", "58745689", "Kolkata", "Engineer", 'M', 457258.00, 250.00, 350.00, 300.00, "Kolkata", "India")),
            //employeeDetails.Add(new EmployeeDetails(1, "Joy", "58745689", "Kolkata", "Engineer", 'M', 457258.00, 250.00, 350.00, 300.00, "Kolkata", "India")),
            //employeeDetails.Add(new EmployeeDetails(1, "Joy", "58745689", "Kolkata", "Engineer", 'M', 457258.00, 250.00, 350.00, 300.00, "Kolkata", "India")),
            //employeeDetails.Add(new EmployeeDetails(1, "Joy", "58745689", "Kolkata", "Engineer", 'M', 457258.00, 250.00, 350.00, 300.00, "Kolkata", "India"))

            //EmployeePayrollOperation employeePayrollOperation = new EmployeePayrollOperation();
            //employeePayrollOperation.addEmployeePayroll(employeeDetails);
            // employeePayrollOpreation.EmployeePalyRoll(employeeDeatails);

            //Parallel Threading


            string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

            Parallel.Invoke(() =>
            {
                Console.WriteLine("Begin first task.....");
                GetLongestWord(words);
            },

            () =>
            {
                Console.WriteLine("Begin second task....");
                GetMostCommonWords(words);
            },
            () =>
            {
                Console.WriteLine("Begin third task....");
                GetCountForWords(words, "sleep");
            }
        );

            static string[] CreateWordArray(string uri)
            {
                Console.WriteLine($"Retrieving from {uri}");
                string s = new System.Net.WebClient().DownloadString(uri);

                return s.Split(
                    new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' },
                    StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private static string GetLongestWord(string[] words)
        {
            var longestWord = (from w in words
                               orderby w.Length descending
                               select w).First();
            Console.WriteLine($"Task 1 -- The LONGEST WORD is {longestWord}");
            return longestWord;
        }

        private static void GetCountForWords(string[] words, string term)
        {
            var findwords = from word in words
                            where word.ToUpper().Contains(term.ToUpper())
                            select word;
            Console.WriteLine($@"Task 3 ---- the word ""{term}"" occurs {findwords.Count()} times.");

        }

        private static void GetMostCommonWords(string[] words)
        {
            var frequencyorder = from word in words
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commanwords = frequencyorder.Take(10);
            System.Text.StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 2 -- the most common words are :");
            foreach (var v in commanwords)
            {
                sb.AppendLine(" " + v);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
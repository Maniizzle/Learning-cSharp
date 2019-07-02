using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaymentRole
{
    class Program
    {
        static void Main(string[] args)
        {

            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            EmployeePayrollReport rpt = new EmployeePayrollReport();
            rpt.GenerateReport(doc + "\\2019_April_Salary_Report", EmployeePayrollReport.DocumentType.Txt);

            Console.ReadLine();
        }
    }
}

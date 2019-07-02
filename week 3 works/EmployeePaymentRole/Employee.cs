using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaymentRole
{
    public class AppConstants
    {
        public const string EMOLOYEE_TYPE_CONTRACT = "CONTRACT";
        public const string EMPLOYEE_TYPE_PERMANENT = "PERMANENT";
        public const string EMPLOYEE_TYPE_INTERN = "INTERN";
        //
        public const string GENDER_MALE = "MALE";
        public const string GENDER_FEMALE = "FEMALE";
    }

    public enum Gender { 
        Male=20,Female=30
}
    public enum EmployeeType
    {
        Contract, Permanent, Intern
    }
    public class Employee
    {
        public Employee(EmployeeType empt)
        {
            Group = empt;
        }
        public Employee()
        {
            Group = EmployeeType.Permanent;
        }
        public Gender Gender { get; set; } = Gender.Male;
        public EmployeeType Group { get; set; }

        public decimal CalculateSalary(int noOfDays=0)
        {
            noOfDays = noOfDays < 0 ? 0 : noOfDays;
            decimal res = 0.0m;
            switch (Group)
            {
                case EmployeeType.Contract:
                    res = noOfDays * 15000;
                    break;
                case EmployeeType.Permanent:
                    res = noOfDays * 20000;
                    break;
                case EmployeeType.Intern:
                    res = noOfDays * 5000;
                    break;
            }
                    return res;            
        }
    }
}

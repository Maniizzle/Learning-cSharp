using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostingPlatform
{
    class Program
    {
        static void Main(string[] args)
        { UserCompanyInfo james = new UserCompanyInfo("Cozy Shoes", "24,Dolphin Estate", "08146458222");
            UserIdentity john = new UserIdentity("Mane", "Olamide", "Onakoya", "Olamideonakoya1@gmail.com", "08146458222", james);
            Console.WriteLine(john.CompanyInfo);
            Console.ReadLine();
        }
    }
}

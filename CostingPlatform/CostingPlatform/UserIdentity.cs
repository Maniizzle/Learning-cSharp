using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostingPlatform
{

    public class UserIdentity
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public UserCompanyInfo CompanyInfo { get; internal set; }

        public UserIdentity()
            {
            CompanyInfo= new UserCompanyInfo();
            }

        public UserIdentity(string userName,string firstName,string lastName):this()
        {
            Username = userName ?? Guid.NewGuid().ToString();
            LastName = lastName;
            FirstName = firstName;
            
        }
            
        public UserIdentity(string userName, string firstName,string lastName, string email):this(userName,firstName,lastName)
        {
            Email = email;

        }

        
    }

    
}

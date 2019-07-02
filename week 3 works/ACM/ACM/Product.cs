using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    class Product
    {
       
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; internal set; }

        public bool Validate()
        {
            return true;
        }

        public string Retrieve()
        {
            return "";
        }

        public string Save()
        {
            return "";
        }
    }
}

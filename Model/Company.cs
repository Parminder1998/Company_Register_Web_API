using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_Register_Web_API.Model
{
    public class Company // company class 
    {
        public int Id { get; set; }

        public string Name { get; set; } // company name 

        public int AnnualNetProfit {get; set;} // anual profit

        public int NumberOfEmployees { get; set; } //no. of employess



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fast_Food.Models
{
    public enum Cities
    { 
    VelikoTarnovo,
    Sofia,
    Lovech,
    Pleven,
    Plovdiv,
    Varna,
    Burgas
    }
    public enum States
    { 
    Bulgaria
    }
    
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
    }
}

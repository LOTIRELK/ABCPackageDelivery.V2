using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPackageDelivery
{
    public class OverNightCustomer:OverNightPackage
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }

        public OverNightCustomer():base()
        {
            name = "";
            address = "";
            city = "";
            state = "";
            zipCode = "";
        }

        public OverNightCustomer(double weight, double costPerOunce, int id, double xtraFee, string Name, string Address, string City, string State, string ZipCode):base(weight, costPerOunce, id, xtraFee)
        {
            this.name = Name;
            this.address = Address;
            this.city = City;
            this.state = State;
            this.zipCode = ZipCode;
        }

        public override string displayPackageDetails(string i)
        {
           return name + i + address + i + city + i + state + i + zipCode;
        }
    }
}

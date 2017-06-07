using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPackageDelivery
{
    public class TwoDayCustomer:TwoDayPackage
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }

        public TwoDayCustomer():base()
        {
            name = "";
            address = "";
            city = "";
            state = "";
            zipCode = "";
        }

        public TwoDayCustomer(double weight, double costPerOunce, int id, double flatFee,string Name, string Address, string City, string State, string ZipCode) : base(weight, costPerOunce, id, flatFee)
        {
            this.name = Name;
            this.address = Address;
            this.city = City;
            this.state = State;
            this.zipCode = ZipCode;
        }

        public override string displayPackageDetails(string i)
        {
           return name + i + address + i + city +i + state + i + zipCode;
        }
    }
}

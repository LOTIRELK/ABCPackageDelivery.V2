using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPackageDelivery
{
    public class OverNightCourier:OverNightCustomer
    {
        public string companyName { get; set; }

        public OverNightCourier() : base()
        {
            companyName = "";
        }

        public OverNightCourier(double weight, double costPerOunce, int id, double xtra, string companyName, string Name, string Address, string City, string State, string ZipCode) : base(weight, costPerOunce, id, xtra, Name, Address, City, State, ZipCode)
        {
            this.companyName = companyName;
        }

        public override double CalculateCost()
        {
            double cost = weight * (costPerOunce+xtraFee)*2;
            return cost;
        }

        public override string displayPackageDetails(string i)
        {
           return name + i +companyName+i+ address + i + city + i + state + i + zipCode;
        }
    }
}

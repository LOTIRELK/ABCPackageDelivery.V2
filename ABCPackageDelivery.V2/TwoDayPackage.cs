using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPackageDelivery
{
   public class TwoDayPackage:Package
    {
        public double flatFee { get; set; }

        public TwoDayPackage() : base()
        {
            flatFee = 0;
        }

        public TwoDayPackage(double weight, double costPerOunce, int id, double flatFee) : base(weight, costPerOunce, id)
        {
            this.flatFee = flatFee;
        }
        public override double CalculateCost()
        {
            double cost = flatFee + (weight * costPerOunce);
            return cost;
        }

        public override string displayPackageDetails(string i)
        {
            return Convert.ToString(packageID) + Convert.ToString(weight) + i + Convert.ToString(costPerOunce) +  i + Convert.ToString(flatFee);
        }
    }
}

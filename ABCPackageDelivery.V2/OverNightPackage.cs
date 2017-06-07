using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPackageDelivery
{
    public class OverNightPackage:Package
    {

        public double xtraFee { get; set; }

        public OverNightPackage() : base()
        {
            xtraFee = 0;
        }

        public OverNightPackage(double weight, double costPerOunce, int id, double xtraFee) : base(weight, costPerOunce, id)
        {
            this.xtraFee = xtraFee;
        }

        public override double CalculateCost()
        {
            double cost = (xtraFee + costPerOunce)*weight;
            return cost;
        }

        public override string displayPackageDetails(string i)
        {
           return packageID + weight + i + Convert.ToString(costPerOunce) + i + Convert.ToString(xtraFee);
        }
    }
}

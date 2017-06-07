using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPackageDelivery
{
    public abstract class Package
    {
        public double weight { get; set; }
        public double costPerOunce { get; set; }
        public int packageID { get; set; }

        public Package()
        {
            weight = 0;
            costPerOunce = 0;
            packageID = 0;
        }
        public Package(double Weight, double CostPerOunce, int PackageID)
        {
            if (Weight < 0)
            {
                Console.WriteLine("Weight must be positive.");
            }
            else
            {
                this.weight = Weight;
            }
            if (CostPerOunce < 0)
            {
                Console.WriteLine("Cost per ounce must be positive.");
            }
            else
                this.costPerOunce = CostPerOunce;

            this.packageID = PackageID;
        }
        public virtual double CalculateCost()
        {
            double cost = weight * costPerOunce;
            return cost;
        }

        public abstract string displayPackageDetails(string i);

    }
}

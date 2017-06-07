using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPackageDelivery
{
    class OverNightSender:OverNightCustomer
    {
        public OverNightSender() : base()
        {
        }

        public OverNightSender(double weight, double costPerOunce, int id, double xtra, string Name, string Address, string City, string State, string ZipCode) : base(weight, costPerOunce, id, xtra, Name, Address, City, State, ZipCode)
        {

        }
    }
}

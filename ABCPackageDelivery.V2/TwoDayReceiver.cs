using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPackageDelivery
{
    class TwoDayReceiver : TwoDayCustomer
    {
        public TwoDayReceiver() : base()
        {
        }

        public TwoDayReceiver(double weight, double costPerOunce, int id, double flatFee, string Name, string Address, string City, string State, string ZipCode) : base(weight, costPerOunce, id, flatFee, Name, Address, City, State, ZipCode)
        {

        }

    }
}

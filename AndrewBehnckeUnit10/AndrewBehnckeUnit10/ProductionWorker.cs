using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewBehnckeUnit10
{
    /**
     *  ProductionWorker Class - Extends Employe
     **/
    public class ProductionWorker : Employee
    {
        private int shift;
        private double payRate;
        public int Shift {
            get { return shift; }
            set { shift = value; }
        }
        public double PayRate {
            get { return payRate; }
            set { payRate = value; }
        }
    }
}

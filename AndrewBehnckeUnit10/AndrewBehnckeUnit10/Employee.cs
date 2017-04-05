using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewBehnckeUnit10
{
    /**
     *  Employee Clas - Will be extended by ProductionWorker
     **/
    public class Employee
    {
        private string name;
        private int number;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Number {
            get { return number; }
            set { number = value; }
        }



    }
}

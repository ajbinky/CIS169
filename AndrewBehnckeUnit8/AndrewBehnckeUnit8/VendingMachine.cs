using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewBehnckeUnit8
{

    class VendingMachine
    {

        /**
         *  Class variables
         **/
        private Soda[] sodas;
        private double sales;

        /**
         *  Constructor
         **/
        public VendingMachine()
        {
            sodas[0] = new AndrewBehnckeUnit8.Soda("Cola", 1);
            sodas[1] = new AndrewBehnckeUnit8.Soda("Root Beer", 1);
            sodas[2] = new AndrewBehnckeUnit8.Soda("Lemon Lime Soda", 1);
            sodas[3] = new AndrewBehnckeUnit8.Soda("Grape Soda", 1.5);
            sodas[4] = new AndrewBehnckeUnit8.Soda("Cream Soda", 1.5);
        }

        public bool buySoda()
        {

        }

    }

    class Soda
    {

        private string name;
        private double cost;
        private int stock;

        public Soda(string name, double cost)
        {
            this.name = name;
            this.cost = cost;
            this.stock = 20;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public double getCost()
        {
            return cost;
        }

        public void setCost(double cost)
        {
            this.cost = cost;
        }

        public int getStock() {
            return stock;
        }

        public void setStock(int stock) {
            this.stock = stock;
        }

    }

}

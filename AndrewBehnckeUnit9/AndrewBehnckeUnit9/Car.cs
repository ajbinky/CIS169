using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewBehnckeUnit9
{

    public class Car
    {
        private string year;
        private string make;
        private int speed;

        /**
         * Car constructor, takes year and make as parameters
         **/
        public Car(string year, string make)
        {
            this.year = year;
            this.make = make;
            this.speed = 0;
        }

        /**
         * Accelerate method, as requested
         **/
        public void Accelerate()
        {
            speed += 5;
        }

        /**
         * Brake method, as requested
         **/
        public void Brake()
        {
            speed -= 5;
        }

        /**
         * Added getters for creating new form
         **/
        public string getYear()
        {
            return year;
        }

        public string getMake()
        {
            return make;
        }

        public int getSpeed()
        {
            return speed;
        }

    }
}

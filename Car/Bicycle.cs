using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    public class Bicycle 

    {
        private string brand;
        private int speed;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public Bicycle(string brand, int speed) 
        {
            this.brand = brand;
            this.speed = speed;
        }

        public virtual void Move()
        {
            Console.WriteLine($"The bicycle {Brand} is moving at a maximum speed of {Speed} km/h.");
        }
    }
}

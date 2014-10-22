using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    abstract class Chair: Furniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            :   base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs 
        {
            get
            {
                return this.numberOfLegs;
            }
            set
            {
                if (value > 0)
                {
                    this.numberOfLegs = value;
                }
            }
        }
    }
}

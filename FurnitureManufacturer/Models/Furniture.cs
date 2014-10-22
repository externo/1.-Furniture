using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    abstract class Furniture: IFurniture
    {
        //fields
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material.ToString();
            this.Price = price;
            this.Height = height;
        }

        public string Model 
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != null && value.Length > 3)
                {
                    this.model = value;
                }
            }
        }

        public string Material 
        {
            get
            {
                return this.material;
            }
            set
            {
               this.material = value;
            }
        }

        public decimal Price 
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
            }
        }

        public decimal Height 
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
            }
        }
    }
}

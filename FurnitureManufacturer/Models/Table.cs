using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class Table: Furniture, ITable
    {
        private decimal length;
        private decimal width;
        private decimal area;

        public Table(string model, MaterialType material, decimal price, decimal height, decimal length, decimal width)
            :   base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
            this.area = this.Length * this.Width;
        }

        public decimal Length 
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value > 0)
                {
                    this.length = value;
                }
            }
        }

        public decimal Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
            }
        }

        public decimal Area 
        {
            get
            {
                return this.area;
            }
        }
    }
}

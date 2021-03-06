﻿using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class Company: ICompany
    {
        private string name;
        private string registrationNumber;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }


        public string Name
        {
            get
            {

            }
            set
            {

            }
        }

        public string RegistrationNumber 
        {
            get
            {

            }
            set
            {

            }
        }

        public Collection<Furniture> Furnitures { get; }

        public void Add(Furniture furniture);

        public void Remove(Furniture furniture);

        Furniture Find(string model);

        public string Catalog()
        {
            string result = String.Format("{0} - {1} - {2} {3}",
                                            this.Name,
                                            this.RegistrationNumber,
                                            this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                                            this.Furnitures.Count != 1 ? "furnitures" : "furniture"
                                            );
            foreach (var Furniture in this.Furnitures)
            {
                result += "\n" + Furniture.ToString();
            }
            return result;
        }
    }
}

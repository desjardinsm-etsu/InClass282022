using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass282022
{
    public class Parent : Person
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();


        public Parent(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void AddVehicle(int year)
        {
            Vehicles.Add(new Vehicle(year));
        }

        public virtual void AddVehicle(DateTime date)
        {
            Vehicles.Add(new Vehicle(date));
        }
    }
}

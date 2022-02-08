using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass282022
{
    public class Child : Parent
    {
        public Child(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void AddVehicle(DateTime date)
        {
            date = date.AddYears(-5);

            Vehicles.Add(new Vehicle(date));
        }
    }
}

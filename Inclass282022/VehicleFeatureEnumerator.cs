using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Something to change
namespace Inclass282022
{
    internal class VehicleFeatureEnumerator : IEnumerator<string>
    {
        private Vehicle _vehicle;
        private int index;

        public VehicleFeatureEnumerator(Vehicle veh)
        {
            _vehicle = veh;
            index = -1;
        }
        public object Current => Current;

        string IEnumerator<string>.Current => _vehicle.GetListItem(index);

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            return ++index < _vehicle.GetList().Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}

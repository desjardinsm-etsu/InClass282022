using System.Collections;

namespace Inclass282022
{
    public class Vehicle: IEnumerable<string>
    {
        public int Year { get; set; }

        private List<string> _features = new List<string>();

        public string this[int index] => _features[index];

        public Vehicle(int year)
        {
            this.Year = year;
        }

        public Vehicle(DateTime date)
        {
            Year = date.Year;
        }

        internal void AddFeature(string v)
        {
           _features.Add(v);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new VehicleFeatureEnumerator(this);
        }

        public string GetListItem(int index)
        {
            return _features[index];
        }

        public List<string> GetList()
        {
            return this._features;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
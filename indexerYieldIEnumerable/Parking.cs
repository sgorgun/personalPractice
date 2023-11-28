using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexerYieldIEnumerable
{
    internal class Parking : IEnumerable
    {
        private List<Car> _cars = new List<Car>();
        private const int MaxCars = 100;

        public Car this[string number] //Iterator
        {
            get
            {
                foreach (var car in _cars)
                {
                    if (car.Number == number)
                    {
                        return car;
                    }
                }
                return null;
            }
        }

        public Car this[int position]
        {
            get
            {
                if (position < _cars.Count)
                {
                    return _cars[position];
                }

                return null;
            }

            set
            {
                if (position < _cars.Count)
                {
                    _cars[position] = value;
                }
            }
        }

        public int Count => _cars.Count;
        public string Name { get; set; }

        public int Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car is null.");
            }

            if (_cars.Count < MaxCars)
            {
                _cars.Add(car);
                return _cars.Count - 1;
            }

            return -1;
        }

        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "Number is empty.");
            }

            for (int i = 0; i < _cars.Count; i++)
            {
                if (_cars[i].Number == number)
                {
                    _cars.RemoveAt(i);
                    break;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Car car in _cars)
            {
                yield return car;
            }
        }

        public IEnumerable GetNames()
        {
            foreach (Car car in _cars)
            {
                yield return car.Name;
            }
        }

        //public IEnumerator<Car> GetEnumerator()
        //{
        //    return _cars.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{  return _cars.GetEnumerator(); }

    }

    //public class ParkingEnumerator : IEnumerator
    //{
    //    public object Current => throw new NotImplementedException();

    //    public bool MoveNext()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Reset()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}

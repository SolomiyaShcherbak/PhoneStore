using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    public class BrandComparer<T> : IComparer<T> where T : IDevice
    {
        public int Compare(T item1, T item2)
        {
            return String.Compare(item1.Brand, item2.Brand);
        }
    }

    public class ModelComparer<T> : IComparer<T> where T : IDevice
    {
        public int Compare(T item1, T item2)
        {
            return String.Compare(item1.Model, item2.Model);
        }
    }

    public class PriceComparer<T> : IComparer<T> where T : IDevice
    {
        public int Compare(T item1, T item2)
        {
            return item1.Price.CompareTo(item2.Price);
        }
    }
}

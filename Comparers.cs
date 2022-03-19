﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    class BrandComparer<T> : IComparer<T> where T : IDevice
    {
        public int Compare(T item1, T item2)
        {
            return String.Compare(item1.Brand, item2.Brand);
        }
    }

    class ModelComparer<T> : IComparer<T> where T : IDevice
    {
        public int Compare(T item1, T item2)
        {
            return String.Compare(item1.Model, item2.Model);
        }
    }

    class PriceComparer<T> : IComparer<T> where T : IDevice
    {
        public int Compare(T item1, T item2)
        {
            return item1.Price.CompareTo(item1.Price);
        }
    }
}

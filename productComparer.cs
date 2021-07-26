using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBChallenge
{
    class productComparer : IEqualityComparer<product>
    {
        public productComparer() { }
        public bool Equals(product a, product b)
        {
            if (a.name == b.name && a.price == b.price && a.weight == b.weight)
                return true;
            else
                return false;
        }

        public int GetHashCode(product obj)
        {
            int hash = 12;
            hash = (hash * 7) + obj.name.GetHashCode();
            hash = (hash * 7) + obj.price.GetHashCode();
            hash = (hash * 7) + obj.weight.GetHashCode();

            return hash;

        }
    }
}

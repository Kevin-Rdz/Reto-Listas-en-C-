using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retoprimerparcialcs
{
    public interface Iterator<T>
    {
        bool hasNext();
        T next();
    }
}
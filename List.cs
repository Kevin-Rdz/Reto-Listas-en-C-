using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retoprimerparcialcs
{
    public interface List<T>
    {
        void add(T data);
        T get(int index);
        void delate(int index);
        int getSize();
        Iterator<T> getIterator();

    }
}
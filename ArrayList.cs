using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retoprimerparcialcs
{
    public class Arraylist<H> : List<H>
    {
        private Object[] array;
        private int size;

        public void ArrayList()
        {
            this.array = new Object[10];
        }

        public void add(H data) 
        {
            if (size >= array.Length)
            {
                Object[] arrayN = new Object[array.Length + 2];
                for (int i = 0; i < array.Length; i++)
                {
                    arrayN[i] = array[i];
                }
                this.array = arrayN;

            }
            this.array[size] = data;
            size++;
        }

        public H get(int index)
        {
            return (H)array[index];
        }

        public void delate(int index)
        {

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            size--;

        }
        public int getSize()
        {

            return size;
        }


        public Iterator<H> getIterator()
        {
            return new ForwardIterator();
        }



    
        public class ForwardIterator : Iterator<H>
        {

            private int current;
            private Arraylist<H> arraylist;
            public ForwardIterator()
            {
                this.current = 0;
            }
            public ForwardIterator(Arraylist<H> arraylist)
            {
                this.arraylist = arraylist;
                this.current = 0;
            }

            public bool hasNext() { return current < arraylist.size; }


            public H next()
            {
                H data = (H)arraylist.array[current];
                current++;
                return data;
            }
        }

        
    }
}




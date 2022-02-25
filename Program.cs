using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Retoprimerparcialcs 
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> lista1 = new LinkedList<int>();
            List<string> lista2 = new LinkedList<string>();
           

            lista1.add(1);
            lista1.add(2);
            lista1.add(3);
            lista1.add(4);
            lista1.add(5);


            lista2.add("Jesus");
            lista2.add("Salomon");
            lista2.add("Yael");
            

            Console.WriteLine("PRIMERA LISTA");
            Console.WriteLine("El tamaño es: {0}", lista1.getSize());

            Iterator<int> it = lista1.getIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: {0}", element);
            }
            Console.WriteLine("\n");
            Console.WriteLine("SEGUNDA LISTA");
            lista1.delate(2); //Borra el dato que hay en la posición que pongas dentro de los paréntesis
          

           it = lista1.getIterator();
            Console.WriteLine("El tamaño es:{0}", lista1.getSize());
            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato:{0} ", element);
            }
            Console.WriteLine("\n");
            Console.WriteLine("TERCERA LISTA");
            Console.WriteLine("El tamaño es:{0}", lista2.getSize());
            Iterator<String> itstrings = lista2.getIterator();
            while (itstrings.hasNext())
            {
                Console.WriteLine(itstrings.next());
            }


           
           
        }
    }

}

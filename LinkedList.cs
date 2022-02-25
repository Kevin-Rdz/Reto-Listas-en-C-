using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retoprimerparcialcs
{
    public class LinkedList<G> : List<G>
    {
        private Node<G> head;
        private Node<G> tail;
        private int size;

        public LinkedList()
        {
            listaCount++;
        }
        private static int listaCount = 0;
        public static int getListaCount()
        {
            return listaCount;
        }

        public class Node<T>
        {
            internal readonly T data;
            internal Node<T> previous;
            internal Node<T> next;

            public Node(T data)
            {
                this.data = data;
            }
        }
        private class ForwardIterator : Iterator<G>
        {
            private Node<G> currentNode;

            public G next()
            {
                G data = currentNode.data;
                currentNode = currentNode.next;
                return data;
            }

            public bool hasNext()
            {
                return currentNode != null;
            }

            Node<G> getCurrentNode()
            {
                return currentNode;
            }

            public void setCurrentNode(Node<G> currentNode)
            {
                this.currentNode = currentNode;
            }
        }
       


        public void add(G data)
        {
            Node<G> node = new Node<G>(data);
            node.previous = tail;

            if (tail != null)
            {
                tail.next = node;
            }

            if (head == null)
            {
                head = node;
            }

            tail = node;
            size++;
        }

        public Iterator<G> getIterator()
        {
            ForwardIterator it = new ForwardIterator();
            it.setCurrentNode(head);
            return it;
        }


        public G get(int index)
        {
            Node<G> currentNode = head;
            int currentIndex = 0;
            while (currentIndex < index)
            {
                currentNode = currentNode.next;
                currentIndex++;
            }

            return currentNode.data;
        }


        public void delate(int index)
        {
            Node<G> currentNode = head;
            int currentIndex = 0;

            if (index < 0 || index >= size)
            {
                return;
            }
            else
            {
                size--;
                if (size == 0)
                {
                    head = null;
                    tail = null;
                }
                else if (index == size)
                {
                    tail = tail.previous;
                    tail.next = null;
                }
                else if (index > 0 && index < size)
                {
                    while (currentIndex < index)
                    {
                        currentNode = currentNode.next;
                        currentIndex++;
                    }
                    currentNode.previous.next = currentNode.next;
                    currentNode.next.previous = currentNode.previous;
                }
            }
        }



        public int getSize()
        {
            return size;
        }



    }
}

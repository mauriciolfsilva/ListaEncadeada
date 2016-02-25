using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class Lista
    {
        private Element root;

        private Element LastOfUs()
        {
            Element act = root;
            while(act.Next != null)
            {
                act = act.Next;
            }

            return act;
        }

        public void Add(Element a)
        {
            if(root == null)
            {
                root = a;
            }

            else
            {
                LastOfUs().Next = a;
            }
        }

        public void AddAt(Element a, int p)
        {
            int i = 1;
            Element act = root;
            while (i < p - 1)
            {
                act = act.Next;
                i++;
            }

            a.Next = act.Next;
            act.Next = a;

        }

        public void Print()
        {
            Element act = root;

            while(act != null)
            {
                Console.WriteLine(act.Me);
                act = act.Next;
            }
        }
    }
}

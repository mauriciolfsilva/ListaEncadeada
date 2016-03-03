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
            Element act = FindAt(p - 1);

            a.Next = act.Next;
            act.Next = a;
        }

		private Element FindAt(int p)
		{
			int i = 1;
			Element act = root;
			while (i < p)
			{
				act = act.Next;
				i++;
			}

			return act;
		}

        public void AddAfter(Element a, int v)
        {
            Element act = root;
            while(act.Next != null && act.Me != v)
            {
                act = act.Next;
            }

            if(act.Me == v)
			{
				a.Next = act.Next;
				act.Next = a;
            }

			else
			{
				Console.WriteLine("There isn't an Element with value " + v);
			}
        }

		public void ChangePos(int p1, int p2)
		{
			Element e1 = FindAt(p1);
			Element e2 = FindAt(p2);
			int temp = e1.Me;

			e1.Me = e2.Me;
			e2.Me = temp;
		}

		public void DelAt(int p)
		{
			Element e1 = FindAt(p - 1);
			Element e2 = FindAt(p);

			e1.Next = e2.Next;
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

		public int Count()
		{
			Element act = root;
			int i = 1;

			while (act != null)
			{
				i++;
				act = act.Next;
			}

			return i;
		}
    }
}

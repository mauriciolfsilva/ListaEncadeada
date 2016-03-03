using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEncadeada
{
    public partial class Form1 : Form
    {
        Lista lista = new Lista();

        public Form1()
        {
			InitializeComponent();
        }	

		private void Add(object sender, EventArgs e)
		{
			int v = lista.Count();
			Element a = new Element(v);

			lista.Add(a);
			Console.WriteLine("Add Element with value " + v);
			lista.Print();
		}

		private void AddAt(object sender, EventArgs e)
		{
			Random r = new Random();
			int p = r.Next(1,lista.Count());
			int v = lista.Count();
			Element a = new Element(v);

			lista.AddAt(a, p);
			Console.WriteLine("Add Element with value " + v + " at position " + p);
			lista.Print();
		}

		private void DelAt(object sender, EventArgs e)
		{
			Random r = new Random();
			int p = r.Next(1, lista.Count());

			lista.DelAt(p);
			Console.WriteLine("Delete Element at position " + p);
			lista.Print();
		}

		private void ChangePos(object sender, EventArgs e)
		{
			if (lista.Count() >= 2)
			{
				Random r = new Random();
				int p = r.Next(1, lista.Count());
				int p2 = r.Next(1, lista.Count());

				while (p == p2)
				{
					r.Next(1, lista.Count());
				}

				lista.ChangePos(p,p2);
				Console.WriteLine("Change the position of the elements in the positions " + p + " and " + p2);
				lista.Print();
			}

			else
			{
				Console.WriteLine("There is only one element in this List, you can't do this");
			}

		}

		private void AddAfter(object sender, EventArgs e)
		{
			int v = lista.Count();
			Element a = new Element(v);
			Random r = new Random();
			int v2 = r.Next(1, lista.Count());

			lista.AddAfter(a, v2);
			Console.WriteLine("Add Element whith value " + v + " after the Element whith value " + v2);
			lista.Print();

		}
    }
}

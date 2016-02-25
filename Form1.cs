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
        Element a = new Element(0);
        Element b = new Element(1);
        Element c = new Element(2);
        Element d = new Element(3);
        Element e = new Element(7);

        public Form1()
        {
            lista.Add(a);
            lista.Add(b);
            lista.Add(c);
            lista.Add(d);
            lista.Print();
            lista.AddAt(e,2);
            lista.Print();
        }
    }
}

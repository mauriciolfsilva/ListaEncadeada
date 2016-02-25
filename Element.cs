using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class Element
    {
        private int me;
        private Element next;
        private Element last;

        public Element(int m)
        {
            me = m;
            next = null;
            last = null;
        }
        public Element(int m, Element n)
        {
            me = m;
            next = n;
            last = null;
        }
        public Element(int m, Element n, Element l)
        {
            me = m;
            next = n;
            last = l;
        }

        public int Me
        {
            get
            {
                return me;
            }

            set
            {
                me = value;
            }
        }

        public Element Next
        {
            get
            {
                return  next;
            }

            set
            {
                next = value;
            }
        }

        public Element Last
        {
            get
            {
                return last;
            }

            set
            {
                last = value;
            }
        }
    }
}

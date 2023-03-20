using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps5
{
    internal class Kvartira : Dom
    {
        private int komnat;
        private string _kvartira;
        public string _Kvartira
        {
            get { return _kvartira; }
            set { _kvartira = value; }
        }
        public int Komnat
        {
            get
            {
                return komnat;
            }
            set
            {
                komnat = value;
            }
        }

    }
}

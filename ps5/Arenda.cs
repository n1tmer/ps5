using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps5
{
    public class Arenda : plata
    {
         public int komnat;
         public int arenda;

        public int Komnat
        {
            get
            {
                return komnat;
            }
            set
            {
                Komnat = value;
            }
        }

        public int Arenda1
        {
            get
            {
                return arenda;
            }
             set
            {
                arenda = value;
            }
        }
        public virtual void Arend()
        {
            

            if (komnat <= 0)
            {
                Console.WriteLine("Укажите количество комнат!");
            }
            if (komnat == 1)
            {
                arenda = 16000;
            }
            if (komnat == 2)
            {
                arenda = 24000;
            }
            if (komnat == 3)
            {
                arenda = 35000;
            }
            int b = Console.Read();
            int c = 0;
            if (b == 1 && komnat == 1)
            {
                arenda = 16000;
                c = arenda / b;
            }
            if (b == 2 && komnat == 1)
            {
                arenda = 16000;
                c = arenda / b;
            }
            if (b == 1 && komnat == 2)
            {
                arenda = 24000;
                c = arenda / b;
            }
            if (b == 2 && komnat == 2)
            {
                arenda = 24000;
                c = arenda / b;
            }
            if (b == 3 && komnat == 2)
            {
                arenda = 24000;
                c = arenda / b;
            }
            if (b == 1 && komnat == 3)
            {
                arenda = 35000;
                c = arenda / b;
            }
            if (b == 2 && komnat == 3)
            {
                arenda = 35000;
                c = arenda / b;
            }
            if (b == 3 && komnat == 3)
            {
                arenda = 35000;
                c = arenda / b;
            }
            
            
        }
    }
}

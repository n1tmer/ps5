using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ps5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arenda _arenda = new Arenda();
            Kvartira _kvartira1 = new Kvartira();
            Console.WriteLine("Введите желаемое количество комнат в квартире");
            _kvartira1.Komnat = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число проживающих");
                int b = int.Parse(Console.ReadLine());
            int p1c = 0;
            if (_kvartira1.Komnat <= 0)
            {
                Console.WriteLine("Неверное количество комнат!");
            }
            if (b == 1 && _kvartira1.Komnat == 1)
                {
                _kvartira1._Kvartira = "Однокомнатная квартира";
                _arenda.Arenda1 = 16000;
                    p1c = _arenda.Arenda1 / b;
                }
                if (b == 2 && _kvartira1.Komnat == 1)
                {
                _kvartira1._Kvartira = "Однокомнатная квартира";
                _arenda.Arenda1 = 16000;
                    p1c = _arenda.Arenda1 / b;
                }
                if (b == 1 && _kvartira1.Komnat == 2)
                {
                _kvartira1._Kvartira = "Двухкомнатная квартира";
                _arenda.Arenda1 = 24000;
                    p1c = _arenda.Arenda1 / b;
                }
                if (b == 2 && _kvartira1.Komnat == 2)
                {
                _kvartira1._Kvartira = "Двухкомнатная квартира";
                _arenda.Arenda1 = 24000;
                    p1c = _arenda.Arenda1 / b;
                }
                if (b == 3 && _kvartira1.Komnat == 2)
                {
                _kvartira1._Kvartira = "Двухкомнатная квартира";
                _arenda.Arenda1 = 24000;
                    p1c = _arenda.Arenda1 / b;
                }
                if (b == 1 && _kvartira1.Komnat == 3)
                {
                _kvartira1._Kvartira = "Трехкомнатная квартира";
                _arenda.Arenda1 = 35000;
                    p1c = _arenda.Arenda1 / b;
                }
                if (b == 2 && _kvartira1.Komnat == 3)
                {
                _kvartira1._Kvartira = "Трехкомнатная квартира";
                _arenda.Arenda1 = 35000;
                    p1c = _arenda.Arenda1 / b;
                }
                if (b == 3 && _kvartira1.Komnat == 3)
                {
                _kvartira1._Kvartira = "Трехкомнатная квартира";
                _arenda.Arenda1 = 35000;
                    p1c = _arenda.Arenda1 / b;
                }
                Console.WriteLine($"Вы выбрали {_kvartira1._Kvartira}, стоимость аренды составляет {_arenda.Arenda1}, число проживающих {b}, плата с одного человека составляет {p1c}");
            Console.ReadLine();

            }

        }
        interface plata
        {
            void Arend();
        }
    }


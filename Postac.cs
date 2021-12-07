using System;
using System.Collections.Generic;
using System.Text;

namespace PowiedzmyZeGra
{
    class Postac
    {
        string imie;
        public int sila;
        public int zdrowie;
        public int charyzma;

        public Postac(string imie, int sila, int zdrowie, int charyzma)
        {
            this.imie = imie;
            this.sila = sila;
            this.zdrowie = zdrowie;
            this.charyzma = charyzma;
        }
        public int DodajSile()
        {
            return sila++;
        }
        public int DodajZdrowie()
        {
            return zdrowie++;
        }
        public int DodajCharyzme()
        {
            return charyzma++;
        }
    }
}
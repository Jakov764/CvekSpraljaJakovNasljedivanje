﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovNasljeđivanje
{
    class ComboBox : IControl
    {
        private int brojac;
        public int Brojac
        {
            get { return brojac; }
            set { brojac = value; }
        }

        public void Metoda()
        {
            Console.WriteLine("ComboBox");

        }
    }
}

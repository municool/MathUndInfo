using System;
using System.Collections.Generic;
using System.Text;

namespace MathGruppenAufgaben
{
    public class MathAndInfoOne
    {
        public void Assoziativ()
        {
            var a = Pow(10, 20);
            var b = -Pow(10, 20);
            var c = 1;

            var sol1 = (a + b) + c;
            //a = 1E+20; b = -1E+20; c = 1; --> b + c wird nicht richtig angezeigt, da zu grosse zahl bzw +1 verliert sich in den stellen
            //mit der grösse des CPU(64bit) batches werden die stellen verloren(die genauigkeit geht weg)
            var sol2 = a + (b + c);

            Console.WriteLine("Lösung 1: " + sol1);
            Console.WriteLine("Lösung 2: " + sol2);
        }

        public void Null()
        {
            var counter = 0;
            double start = 1;
            while (start > 0)
            {
                start /= 2;
                counter++;
            }

            Console.WriteLine("Iterationen: " + counter);
        }

        public void Pi()
        {
            int A = 0;
            int B = 4;

            while (A < B)
            {

            }
        }


        public Int64 Pow(Int64 basis, Int64 expo)
        {
            Int64 res = basis;
            for (int i = 0; i < expo - 1; i++)
            {
                res *= basis;
            }

            return res;
        }
    }
}

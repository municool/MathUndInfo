using System;
using System.Linq;

namespace MathGruppenAufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("-?"))
            {
                Console.WriteLine("-pi");
                Console.WriteLine("-asso");
                Console.WriteLine("-null");
                Console.WriteLine("-poAdd [PolynomA] [PolynomB]");
                Console.WriteLine("--> Polynom muss ein string mit Kommageteilten zahlen bsp. '1,2,0,4,0,2'");
                Console.WriteLine("-poMul [PolynomA] [PolynomB]");
                Console.WriteLine("--> Polynom muss ein string mit Kommageteilten zahlen bsp. '1,2,0,4,0,2'");
                return;
            }

            var mathAndInfoI = new MathAndInfoOne();
            var polA = new Polynom(new float[3] { -4f, -2f, 2f });
            var polB = new Polynom(new float[4] { 15f, 0f, 0f, 4f });
            Polynom polR;

            switch (args[0])
            {
                case "-pi":
                    Console.WriteLine("\n----------------Pi--------------------------\n");
                    mathAndInfoI.Pi();
                    break;
                case "-asso":
                    Console.WriteLine("----------------Assoziativ------------------\n");
                    mathAndInfoI.Assoziativ();
                    break;
                case "-null":
                    Console.WriteLine("\n----------------Null------------------------\n");
                    mathAndInfoI.Null();
                    break;
                case "-poAdd":
                    polR = Polynom.Add(polA, polB);
                    Console.WriteLine("Eval: " + polR.Eval(1f));
                    break;
                case "-poMul":
                    polR = Polynom.Mul(polA, polB);
                    Console.WriteLine("Eval: " + polR.Eval(1f));
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("No such parameter found");
                    Console.ResetColor();
                    break;
            }
            Console.Read();
        }

    }
}

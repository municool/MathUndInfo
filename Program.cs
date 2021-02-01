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
                Console.WriteLine("-poAdd [PolynomA] [PolynomB] [x]");
                Console.WriteLine("--> Polynom muss ein string mit Kommageteilten zahlen bsp. '1,2,0,4,0,2'");
                Console.WriteLine("-poMul [PolynomA] [PolynomB] [x]");
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
                    mathAndInfoI.Pi();
                    break;
                case "-asso":
                    mathAndInfoI.Assoziativ();
                    break;
                case "-null":
                    mathAndInfoI.Null();
                    break;
                case "-poAdd":
                    polA = new Polynom(Array.ConvertAll(args[1].Split(new[] { ',', }, StringSplitOptions.RemoveEmptyEntries),
                                            float.Parse));
                    polB = new Polynom(Array.ConvertAll(args[2].Split(new[] { ',', }, StringSplitOptions.RemoveEmptyEntries),
                                            float.Parse));

                    polR = polA + polB;

                    Console.WriteLine("Result: '" + string.Join(",", polR.GetCoeffs()));
                    Console.WriteLine("Eval: " + polR.Eval(float.Parse(args[3])));
                    break;
                case "-poMul":
                    polA = new Polynom(Array.ConvertAll(args[1].Split(new[] { ',', }, StringSplitOptions.RemoveEmptyEntries),
                                            float.Parse));
                    polB = new Polynom(Array.ConvertAll(args[2].Split(new[] { ',', }, StringSplitOptions.RemoveEmptyEntries),
                                            float.Parse));

                    polR = polA * polB;

                    Console.WriteLine("Result: '" + string.Join(",", polR.GetCoeffs()));
                    Console.WriteLine("Eval: " + polR.Eval(float.Parse(args[3])));
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("No such parameter found");
                    Console.ResetColor();
                    break;
            }
        }

    }
}

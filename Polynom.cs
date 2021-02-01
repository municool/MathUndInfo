using System;
using System.Collections.Generic;
using System.Text;

namespace MathGruppenAufgaben
{
    public class Polynom
    {
        //a + a1 x + a2 x^2 + a3 x^3 + .....

        private float[] Coeffs;

        public Polynom(int degree)
        {
            Coeffs = new float[degree];
        }

        public Polynom(float[] inPoly)
        {
            Coeffs = inPoly;
        }

        public float Eval(float x)
        {
            float result = 0f;
            for (int i = 0; i < Coeffs.Length; i++)
            {
                result = (result + Coeffs[i]) * x;
            }
            
            return result;
        }

        public int GetDegree()
        {
            return Coeffs.Length;
        }

        public float[] GetCoeffs()
        {
            return Coeffs;
        }

        public static Polynom Add(Polynom polA, Polynom polB)
        {
            var len = polA.Coeffs.Length > polB.Coeffs.Length ? polA.Coeffs.Length : polB.Coeffs.Length;
            var newPol = new float[len];

            for (int i = 0; i < polA.Coeffs.Length; i++)
            {
                newPol[i] += polA.Coeffs[i];
            }
            for (int i = 0; i < polB.Coeffs.Length; i++)
            {
                newPol[i] += polB.Coeffs[i];
            }

            return new Polynom(newPol);
        }
        public static Polynom Mul(Polynom polA, Polynom polB)
        {
            var len = polA.Coeffs.Length + polB.Coeffs.Length;
            var newPol = new float[len];

            for (int i = 0; i < polA.Coeffs.Length; i++)
            {
                for (int j = 0; j < polB.Coeffs.Length; j++)
                {
                    newPol[i + j] += polA.Coeffs[i] * polB.Coeffs[j];
                }
            }

            return new Polynom(newPol);
        }
    }
}

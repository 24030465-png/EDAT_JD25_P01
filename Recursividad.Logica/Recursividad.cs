using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividad.Logica
{
    public class Recursividad
    {
        public int Factorial(int numero) 
        {
            // caso base
            if (numero <= 0) 
            {
                return 1;
            }
            //caso general

            return numero*Factorial(numero-1);
        }
        public int Potencia(int numero,int exponente)
        {
            // caso base
            if (exponente == 0)
            {
                return 1;
            }
            //caso general

            return numero * Potencia(numero, exponente-1);
        }

        //serie fibonacci
        public int Fibonacci(int numero)
        {
            //caso base
            if (numero == 1) 
            { 
                return 1;   
            }   
            //caso general
            return numero + Fibonacci(numero-1);
        }
        //inveritr numero
        public int Invertir(int numero) 
        { 
            //caso base
            if(numero <=9)
            {
                return numero*10+numero;
            }
            //caso general
            return Invertir(numero%10);
        }
    }
}

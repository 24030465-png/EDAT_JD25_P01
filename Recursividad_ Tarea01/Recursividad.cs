using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad__Tarea01
{
    public class Recursividad
    {
        public int vocales(String texto)
        {
            if (String.IsNullOrEmpty(texto)) return 0;
            char caracter = char.ToLower(texto[0]);
            int con = 0;
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                con = 1;
            }
            return con + vocales(texto.Substring(1));

        }
        public int suma(int num)
        {
            if(num < 0) return 0;
            return num + suma(num-1);
        }
        public int[] sumaD(int[] num, int i)
        {
            int[] sum=new int[num.Length];
            if (i ==num.Length)
            {
                return sum;
            }
            sum = sumaD(num, i+1 );

            int numero = num[i];
            int n = numero;
            int suma = 0;
            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }
            sum[i] = suma;
            return sum;
            
        }
    }
}

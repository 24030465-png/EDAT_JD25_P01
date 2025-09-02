using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //promedio de numeros enteros
        var numeros=new List<int>() {1,2,3,5,6,3,8,9,9,2,4 };
        var numeroProm = (List<int> num) =>
        {
            int prom=0;
            int cantidad = 0;
            for (int i=0;i<num.Count;i++) {
                prom = prom + num[i];
                cantidad++;
            }
            float promedio = (float)prom / cantidad;
            return promedio;
        };
        float promedio=numeroProm(numeros);
        Console.WriteLine("El promedio de los numeros es: "+promedio);    
        //numero menor
        var numeros2=new List<int>() {1,2,3,4,5,6,900,500,4,70 };
        var numeroMenor = (List<int> num2) =>
        {
            if (num2==null||num2.Count==0) {
                return 0;
            }
                int menor=100000000;
                for (int i= 0; i < num2.Count; i++) {
                    if (menor > num2[i])
                    {
                        menor=num2[i];
                    }
                }
                return menor;
            
        };
        int menor=numeroMenor(numeros2);
        Console.WriteLine("El numero menor es: "+menor);
        //numero mayor
        Func<int, int, int, int> mayor = (a, b, c) =>
        {
            if (a > b && a < c)
            {
                return a;
            }
            if (b > c&& b > a)
            {
                return b;
            }
            return c;
        };
        int may = mayor(4, 5, 6);
        Console.WriteLine("El numero mayor es:  "+may);
        //multiplicacion
        Func<String,int, String> multiplicacion = (a, b) =>
        {
            int num=Int32.Parse(a);
            int multiplicar = num * b;
            String mult=multiplicar.ToString();
            return mult;
        };
        String resultado=multiplicacion("2",3);
        Console.WriteLine("la multiplicacion es: "+resultado);
        Console.ReadKey();
    }
}
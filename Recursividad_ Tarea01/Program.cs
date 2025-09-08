using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("contar vocales");
        String texto = "vaca";
        Recursividad__Tarea01.Recursividad r=new Recursividad__Tarea01.Recursividad();
        int con = r.vocales(texto);
        Console.WriteLine("el numero de vocales de "+texto+" es: "+con);
        Console.WriteLine("sumar los numeros");
        Console.WriteLine("la suma de los primeros numeros es:  " + r.suma(3));
        Console.WriteLine("sumar los digitos de un numero");
        int[] num = { 12, 34, 56 };
        int[] sum = r.sumaD(num, 0);
        int mayor = 0;
        for (int i = 0; i < sum.Length; i++)
        {
            Console.WriteLine("la suma de los digitos de " + num[i] + " es: " + sum[i]);
            if (sum[i] > mayor)
            {
                mayor = sum[i];
            }
        }
        Console.WriteLine("el numero mayor es: " + mayor);
        Console.ReadLine(); 
    }
    
}
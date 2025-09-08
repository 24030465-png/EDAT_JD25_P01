internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Recursividad \n");
        Console.WriteLine("\nCasos de recursividad:  ");
        Console.WriteLine("\nCaso 1: ");
        Recursividad.Logica.Recursividad r = new Recursividad.Logica.Recursividad();
        int resultado=r.Factorial(5); 
        Console.WriteLine("\nEl factorial es:  "+resultado);
        Console.WriteLine($"\nEl factorial es: {resultado}");//interpolar
        Console.WriteLine("\nCaso2: ");
        int resultadop = r.Potencia(2, 10);
        Console.WriteLine("\nEl numero 2 elevado a la 10 es: "+resultadop);
        //tarea02
        Console.WriteLine("\nfactorial de 5: " + r.Factorial(5));
        Console.WriteLine("\nel numero invertido de 123 es: " + r.Invertir(123));
        Console.ReadKey();
        
    }
}
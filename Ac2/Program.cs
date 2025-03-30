internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introduce el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int suma = Suma(num1, num2);
        Console.WriteLine("Suma: " + suma);

        int resta = Resta(num1, num2);
        Console.WriteLine("Resta: " + resta);

        Console.WriteLine("Introduce un número para comprobar si es par:");
        int numPar = Convert.ToInt32(Console.ReadLine());
        bool esPar = EsPar(numPar);
        Console.WriteLine("¿Es par? " + esPar);

        Console.WriteLine("Introduce un número para saber si es positivo o negativo:");
        int num = Convert.ToInt32(Console.ReadLine());
        string texto = TipoNumero(num);
        Console.WriteLine("El numero es: " + texto);

        Console.WriteLine("Introduce una palabra de 4 letras:");
        string palabra = Console.ReadLine();
        int letras = ContarLetras(palabra);
        Console.WriteLine("Número de letras:" + letras);
    }

    public static int Suma(int a, int b)
    {
        return a + b;
    }

    public static int Resta(int a, int b)
    {
        return a - b;
    }

    public static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }

    public static string TipoNumero(int numero)
    {
        if (numero > 0)
        {
            return "Número positivo";
        }
        else if (numero < 0)
        {
            return "Número negativo";
        }
        else
        {
            return "Es cero";
        }
    }

    public static int ContarLetras(string palabra)
    {
        return palabra.Length;
    }
}

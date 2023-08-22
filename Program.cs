internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"{Iterativo(7,3)}");
        Console.WriteLine($"{Recursivo(7,3)}");
        Console.WriteLine($"{FatorialRecursivo(5)}");
        Console.WriteLine($"{FatorialIterativo(5)}");
    }

    static int Iterativo(int m, int n)
    {
        int resultado = 0;
        for (int i = 0; i < n; i++)
        {
            resultado += m;
        }
        return resultado;
    }
    static int Recursivo(int m, int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else
            return m + Recursivo(m, n-1);
    }

    static int FatorialIterativo(int n)
    {
        int resultado = 1;
        if (n == 0)
        {
            return 1;
        }
        else
        {
            for(int i = n; i > 0 ; i--)
            {
                resultado *= i;
            }
        }
        return resultado;
    }
    static int FatorialRecursivo(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
            return n * FatorialRecursivo(n-1);
    }
}
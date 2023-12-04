internal class Program
{
    private static void Main(string[] args)
    {
        bool loop = true;
        int numero1 = 0;
        int numero2 = 0;
        while (loop)
        {
            Random r = new Random();
            numero1 = r.Next(1000, 1500);
            numero2 = r.Next(1000, 1500);
            int suma1 = 0;
            int suma2 = 0;
            for (int i = 1; i < numero1; i++)
            {
                if (numero1 % i == 0)
                {
                    suma1 += i;
                }
            }
            for (int j = 1; j < numero2; j++)
            {
                if (numero2 % j == 0)
                {
                    suma2 += j;
                }
            }
            if (suma1 == numero2 && suma2 == numero1)
            {
                loop = false;
            }
        }
        Console.WriteLine($"Los numeros amistosos son: {numero1} y {numero2}");
    }
}
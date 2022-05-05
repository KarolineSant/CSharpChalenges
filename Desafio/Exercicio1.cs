namespace Exercicio1
{
    class Exercicio1
    {
        static void Main()
        {
            Console.WriteLine("Digite 5 números:");
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());
            decimal e = decimal.Parse(Console.ReadLine());

            decimal[] numeros = { a, b, c, d, e };
            decimal maiorNumero = numeros.Max();
            decimal menorNumero = numeros.Min();
            decimal diferenca = maiorNumero - menorNumero;

            Console.WriteLine("O maior número é {0}", maiorNumero);
            Console.WriteLine("A diferença entre o maior número e o menor número é {0}", diferenca);

        }

    }
}
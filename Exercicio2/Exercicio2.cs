namespace Exercicio2
{
    class Exercicio2
    {
        static void Main()
        {
            Console.WriteLine("Digite 3 números: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);
            Console.WriteLine("O valor de delta é: {0}", delta);

            double raiz = Math.Sqrt(delta);

            var x1 = ((-(b)) + raiz) / (2 * a);
            var x2 = ((-(b)) - raiz) / (2 * a);

            Console.WriteLine("Valor de X': {0}", x1);
            Console.WriteLine("Valor de X'': {0}", x2);

        }
    }
}
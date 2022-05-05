namespace Exercicio3
{
    class Exercicio3
    {
        static void Main()
        {
            int codigoCorreto = 3251;
            Console.WriteLine("Por favor, digite o código: ");
            int a = int.Parse(Console.ReadLine());

            if (a == codigoCorreto)
            {
                Console.WriteLine("Código correto!");
            }

            else if (a < codigoCorreto)
            {
                Console.WriteLine("Código incorreto! O código certo é maior do que o informado!");
            }

            else if (a > codigoCorreto)
            {
                Console.WriteLine("Código incorreto! O código certo é menor do que o informado!");
            }
        }
    }
}
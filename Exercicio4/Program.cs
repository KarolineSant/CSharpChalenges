namespace Exercicio4
{
    class Exercicio4
    {
        static void Main()
        {
            Console.WriteLine("Digite 10 nomes");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string e = Console.ReadLine();
            string f = Console.ReadLine();
            string g = Console.ReadLine();
            string h = Console.ReadLine();
            string i = Console.ReadLine();
            string j = Console.ReadLine();

            string[] nomes = { a, b, c, d, e, f, g, h, i, j };
            Array.Sort(nomes);

            Console.WriteLine("Todos os nomes foram salvos com sucesso!");

            for (int x = 0; x < nomes.Length; x++)
                Console.WriteLine(nomes[x]);
        }
    }
}

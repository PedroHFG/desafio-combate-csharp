namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do primeiro campeão:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Vida inicial: ");
            int life = int.Parse(Console.ReadLine());
            Console.Write("Ataque: ");
            int attack = int.Parse(Console.ReadLine());
            Console.Write("Armadura: ");
            int armor = int.Parse(Console.ReadLine());
            Champion champion1 = new Champion(name, life, attack, armor);

            Console.WriteLine();
            Console.WriteLine("Digite os dados do segundo campeão:");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Vida inicial: ");
            life = int.Parse(Console.ReadLine());
            Console.Write("Ataque: ");
            attack = int.Parse(Console.ReadLine());
            Console.Write("Armadura: ");
            armor = int.Parse(Console.ReadLine());
            Champion champion2 = new Champion(name, life, attack, armor);

            Console.WriteLine();
            Console.Write("Quantos turnos deseja executar? ");
            int turnQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= turnQuantity; i++)
            {
                champion1.TakeDamage(champion2);
                champion2.TakeDamage(champion1);

                Console.WriteLine();
                Console.WriteLine($"Resultado do turno {i}:");
                Console.WriteLine(champion1.Status());
                Console.WriteLine(champion2.Status());

                if (champion1.Life == 0 || champion2.Life == 0)
                {
                    break;
                }

            }

            Console.WriteLine();
            Console.WriteLine("FIM DO COMBATE");
        }
    }
}

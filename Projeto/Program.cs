using System;

namespace Course1._0
{
    class Program
    {
        static void Main()
        {
            Pessoa P1 = new Pessoa("Kleber", 1234, 500.00);
            Pessoa P2 = new Pessoa("Sofia", 4321, 1000.00);
            Pessoa usuario =  new Pessoa() ;

            Console.Write("Já possui conta? (s)sim ou (n)não: ");
            char aux = char.Parse(Console.ReadLine().ToLower());

            if (aux == 's')
            {
                Console.Write("Digite seu PIN: ");
                if (int.TryParse(Console.ReadLine(), out int pin))
                {
                    if (pin == P1.Pin) usuario = P1;
                    else if (pin == P2.Pin) usuario = P2;
                }
            }
            else
            {
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Crie um PIN: ");
                int pin = int.Parse(Console.ReadLine());
                usuario = new Pessoa(nome, pin, 0.00);
            }

            if (usuario != null)
            {
                BancoOperacoes banco = new BancoOperacoes(usuario);
                banco.Menu();
            }
            else
            {
                Console.WriteLine("PIN incorreto. Encerrando.");
            }
        }
    }

}
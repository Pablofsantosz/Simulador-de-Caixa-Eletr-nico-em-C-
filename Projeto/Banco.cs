
using System.Globalization;

namespace Course1._0{
    public class BancoOperacoes
    {
        private Pessoa usuario;

        public BancoOperacoes(Pessoa usuario)
        {
            this.usuario = usuario;
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine($"\nBem-vindo, {usuario.Nome}!");
                Console.WriteLine("1 - Consultar Saldo");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ConsultarSaldo();
                        break;
                    case "2":
                        Depositar();
                        break;
                    case "3":
                        Sacar();
                        break;
                    case "4":
                        Console.WriteLine("Obrigado por usar nosso serviço!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private void ConsultarSaldo()
        {
            Console.WriteLine($"\nSeu saldo atual é: R$ {usuario.Saldo:F2}");
        }

        private void Depositar()
        {
            Console.Write("Digite o valor para depósito: ");
            if (double.TryParse(Console.ReadLine(),CultureInfo.InvariantCulture, out double valor) && valor > 0)
            {
                usuario.Saldo += valor;
                Console.WriteLine("Depósito realizado com sucesso!");
                ConsultarSaldo();
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }

        private void Sacar()
        {
            Console.Write("Digite o valor para saque: ");
            if (double.TryParse(Console.ReadLine(), out double valor) && valor > 0 && valor <= usuario.Saldo)
            {
                usuario.Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
                ConsultarSaldo();
            }
            else
            {
                Console.WriteLine("Saque inválido ou saldo insuficiente!");
            }
        }
    }
}


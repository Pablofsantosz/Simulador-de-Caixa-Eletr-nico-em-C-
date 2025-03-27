namespace Course1._0 
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Pin { get; set; }
        public decimal Saldo { get; set; }

        public Pessoa(string nome, int pin, decimal saldoInicial)
        {
            Nome = nome;
            Pin = pin;
            Saldo = saldoInicial;
        }
        public Pessoa() { 
        }
    }
}
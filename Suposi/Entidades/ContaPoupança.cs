
namespace Suposi.Entidades
{
    class ContaPoupança : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupança()
        {

        }

        public ContaPoupança(int número, string titular, double saldo, double taxaJuros)
            : base(número, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }
        public void AtualizarConta()
        {
            Saldo = Saldo * TaxaJuros;
        }
        public sealed override void Saque(double quantia)
        {
            base.Saque(quantia);
            Saldo = Saldo - 2.0;        
        }
    }
}

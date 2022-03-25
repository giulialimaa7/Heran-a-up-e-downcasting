namespace Suposi.Entidades
{
    class Conta
    {
        public int Número { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int número, string titular, double saldo)
        {
            Número = número;
            Titular = titular;
            Saldo = saldo;
        }
        public void Saque (double quantia)
        {
            Saldo = Saldo - quantia;
        }
        public void Deposito (double quantia)
        {
            Saldo = Saldo + quantia;
        }
    }
}

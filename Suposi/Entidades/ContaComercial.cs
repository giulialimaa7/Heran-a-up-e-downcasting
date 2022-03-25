namespace Suposi.Entidades
{
    class ContaComercial : Conta
    {
        public double LimiteEmprest { get; set; }

        public ContaComercial()
        {
        }
        public ContaComercial(int numero, string titular, double saldo, double limiteEmprest)
            :base(numero, titular,saldo)
        {
            LimiteEmprest = limiteEmprest;
        }
        public void Empréstimo (double quantia)
        {
            if (quantia <= LimiteEmprest)
            {
                Saldo = Saldo + quantia;
            }
        }
    }
}

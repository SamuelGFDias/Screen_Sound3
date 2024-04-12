namespace Teste.Modelos.Conta;

internal class ContaBancaria
{
    protected double Saldo {  get; set; }
    public virtual void Depositar(double valor)
    {
        if (Saldo < 0)
            throw new ArgumentException("O valor a ser depositado não pode ser negativo.");
        Saldo += valor;
    }
    public virtual void Sacar(double valor)
    {
        if (Saldo >= valor)
            throw new ArgumentException("O valor a ser sacado não pode ser maior que o saldo.");
        Saldo -= valor;
    }
    public virtual double CalcularSaldo()
    {
        return Saldo;
    }

}

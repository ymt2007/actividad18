using System;
class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.SetSaldo(500);
        Console.WriteLine(cuenta.Saldo);
    }
}

class CuentaBancaria
{
    private double saldo;
    public void SetSaldo(double valor)
    {
        saldo = valor;
    }
    public string Saldo
    {
        get
        {
            if (saldo > 0)
            {
                return saldo + "";
            }
            return "Saldo no disponible";
        }
    }
}

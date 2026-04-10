using System;

class CuentaBancaria
{
    private double saldo;

    public string Saldo
    {
        get
        {
            if (saldo > 0)
                return saldo.ToString();
            else
                return "Saldo no disponible";
        }
    }

    public void SetSaldo(double valor)
    {
        saldo = valor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.SetSaldo(-50);

        Console.WriteLine(cuenta.Saldo);
    }
}
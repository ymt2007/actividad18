using System;
class Program
{
    static void Main()
    {
        Producto prod = new Producto();
        prod.SetPrecio(10.50); 
        Console.WriteLine(prod.Precio);
    }
}
class Producto
{
    private double precio;

    public void SetPrecio(double valor)
    {
        precio = valor;
    }

    public double Precio
    {
        get
        {
            if (precio >= 0)
            {
                return precio;
            }
            return 0;
        }
    }
}

public class Empleado
{
    private double _salario;
    private const double SalarioMinimo = 4000.00;
    public Empleado(double salario)
    {
        _salario = salario;
    }
    public string Salario
    {
        get
        {
            return _salario >= SalarioMinimo ? _salario.ToString("F2") : "Salario inválido";
        }
    }
}

public class Usuario
{
    private string _contrasena;

    public Usuario(string password)
    {
        _contrasena = password;
    }

    public string Contrasena
    {
        get
        {
            if (string.IsNullOrEmpty(_contrasena) || _contrasena.Length < 8)
            {
                return "Contraseña insegura";
            }
            return "****";
        }
    }
}

namespace Poke.Clases;

public class Ataque
{
    private string nombre;

    private int danio;

    private Type tipo;

    private bool esEspecial;
    
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public double Danio { get; set; }
    public bool EsEspecial { get; set; }

    public Ataque(string nombre, string tipo, double danio, bool esEspecial)
    {
        Nombre = nombre;
        Tipo = tipo;
        Danio = danio;
        EsEspecial = esEspecial;
    }
    
    public double? calcularDanio(Pokemon atacante, Pokemon defensor)
    {
        return null;
    }
}


using System;

public class Habitacion
{
    public int Numero { get; set; }
    public double PrecioPorNoche { get; set; }
    public bool Disponible { get; private set; }
    public string ClienteAsignado { get; private set; }

    public Habitacion(int numero, double precioPorNoche)
    {
        Numero = numero;
        PrecioPorNoche = precioPorNoche;
        Disponible = true;
        ClienteAsignado = string.Empty;
    }
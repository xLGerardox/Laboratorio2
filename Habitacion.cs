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

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Número: {Numero}, Precio por noche: {PrecioPorNoche}, Disponible: {Disponible}, Cliente: {ClienteAsignado}");
    }

    public void CambiarDisponibilidad(bool disponible)
    {
        Disponible = disponible;
    }

    public void AsignarCliente(string nombreCliente)
    {
        ClienteAsignado = nombreCliente;
        CambiarDisponibilidad(false);
    }

    public void LiberarHabitacion()
    {
        ClienteAsignado = string.Empty;
        CambiarDisponibilidad(true);
    }
}
using System;
using System.Collections.Generic;

public class SistemaReservas
{
    private List<Habitacion> habitaciones;

    public SistemaReservas()
    {
        habitaciones = new List<Habitacion>();
    }

    public void AgregarHabitacion(Habitacion habitacion)
    {
        habitaciones.Add(habitacion);
        Console.WriteLine("Se agrego la habitación.");
    }

    public void EliminarHabitacion(int numero)
    {
        var habitacion = habitaciones.Find(h => h.Numero == numero);
        if (habitacion != null)
        {
            habitaciones.Remove(habitacion);
            Console.WriteLine("Habitación eliminada.");
        }
        else
        {
            Console.WriteLine("No se encontro la Habitacióm.");
        }
    }

    public void MostrarHabitaciones()
    {
        foreach (var habitacion in habitaciones)
        {
            habitacion.MostrarInformacion();
        }
    }

    public void AsignarHabitacion(int numero, string nombreCliente)
    {
        var habitacion = habitaciones.Find(h => h.Numero == numero);
        if (habitacion != null && habitacion.Disponible)
        {
            habitacion.AsignarCliente(nombreCliente);
            Console.WriteLine("Habitación asignada.");
        }
        else
        {
            Console.WriteLine("Habitación no disponible.");
        }
    }

    public void LiberarHabitacion(int numero)
    {
        var habitacion = habitaciones.Find(h => h.Numero == numero);
        if (habitacion != null && !habitacion.Disponible)
        {
            habitacion.LiberarHabitacion();
            Console.WriteLine("Habitación liberada.");
        }
        else
        {
            Console.WriteLine("Habitación no encontrada.");
        }
    }
}
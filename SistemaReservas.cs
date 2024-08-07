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
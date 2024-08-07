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
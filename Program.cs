﻿using System;

public class Program
{
    static void Main(string[] args)
    {
        SistemaReservas sistemaReservas = new SistemaReservas();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Agregar Habitación");
            Console.WriteLine("2. Eliminar Habitación");
            Console.WriteLine("3. Mostrar Habitaciones");
            Console.WriteLine("4. Asignar Habitación a Cliente");
            Console.WriteLine("5. Liberar Habitación");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarHabitacion(sistemaReservas);
                    break;
                case 2:
                    EliminarHabitacion(sistemaReservas);
                    break;
                case 3:
                    sistemaReservas.MostrarHabitaciones();
                    break;
                case 4:
                    AsignarHabitacion(sistemaReservas);
                    break;
                case 5:
                    LiberarHabitacion(sistemaReservas);
                    break;
                case 6:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("la opción ingresada no existe.");
                    break;
            }
        }
    }

    static void AgregarHabitacion(SistemaReservas sistemaReservas)
    {
        Console.WriteLine("Seleccione su tipo de habitación:");
        Console.WriteLine("1. Habitación Simple");
        Console.WriteLine("2. Habitación Doble");
        Console.WriteLine("3. Suite");
        Console.WriteLine("4. Habitación Deluxe");
        int tipo = int.Parse(Console.ReadLine());

        Console.Write("Número: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Precio por noche: ");
        double precio = double.Parse(Console.ReadLine());

        switch (tipo)
        {
            case 1:
                Console.Write("Número de camas: ");
                int numeroDeCamas = int.Parse(Console.ReadLine());
                sistemaReservas.AgregarHabitacion(new HabitacionSimple(numero, precio, numeroDeCamas));
                break;
            case 2:
                Console.Write("¿Tiene vista al mar? (true/false): ");
                bool vistaAlMar = bool.Parse(Console.ReadLine());
                sistemaReservas.AgregarHabitacion(new HabitacionDoble(numero, precio, vistaAlMar));
                break;
            case 3:
                Console.Write("Número de habitaciones: ");
                int numeroDeHabitaciones = int.Parse(Console.ReadLine());
                Console.Write("¿Tiene jacuzzi? (true/false): ");
                bool tieneJacuzzi = bool.Parse(Console.ReadLine());
                sistemaReservas.AgregarHabitacion(new Suite(numero, precio, numeroDeHabitaciones, tieneJacuzzi));
                break;
            case 4:
                Console.Write("Servicios extras: ");
                string serviciosExtras = Console.ReadLine();
                sistemaReservas.AgregarHabitacion(new HabitacionDeluxe(numero, precio, serviciosExtras));
                break;
            default:
                Console.WriteLine("Tipo de habitación no valida.");
                break;
        }
    }

    static void EliminarHabitacion(SistemaReservas sistemaReservas)
    {
        Console.Write("Número de la habitación a eliminar: ");
        int numero = int.Parse(Console.ReadLine());
        sistemaReservas.EliminarHabitacion(numero);
    }

    static void AsignarHabitacion(SistemaReservas sistemaReservas)
    {
        Console.Write("Número de la habitación: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Nombre del cliente: ");
        string nombreCliente = Console.ReadLine();
        sistemaReservas.AsignarHabitacion(numero, nombreCliente);
    }

    static void LiberarHabitacion(SistemaReservas sistemaReservas)
    {
        Console.Write("Número de la habitación: ");
        int numero = int.Parse(Console.ReadLine());
        sistemaReservas.LiberarHabitacion(numero);
    }
}
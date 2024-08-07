public class Suite : Habitacion
{
    public int NumeroDeHabitaciones { get; set; }
    public bool TieneJacuzzi { get; set; }

    public Suite(int numero, double precioPorNoche, int numeroDeHabitaciones, bool tieneJacuzzi)
        : base(numero, precioPorNoche)
    {
        NumeroDeHabitaciones = numeroDeHabitaciones;
        TieneJacuzzi = tieneJacuzzi;
    }
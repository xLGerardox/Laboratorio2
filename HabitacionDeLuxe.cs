public class HabitacionDeluxe : Habitacion
{
    public string ServiciosExtras { get; set; }

    public HabitacionDeluxe(int numero, double precioPorNoche, string serviciosExtras)
        : base(numero, precioPorNoche)
    {
        ServiciosExtras = serviciosExtras;
    }

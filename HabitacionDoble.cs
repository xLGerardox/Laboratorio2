public class HabitacionDoble : Habitacion
{
    public bool VistaAlMar { get; set; }

    public HabitacionDoble(int numero, double precioPorNoche, bool vistaAlMar)
        : base(numero, precioPorNoche)
    {
        VistaAlMar = vistaAlMar;
    }
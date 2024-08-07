public class HabitacionDoble : Habitacion
{
    public bool VistaAlMar { get; set; }

    public HabitacionDoble(int numero, double precioPorNoche, bool vistaAlMar)
        : base(numero, precioPorNoche)
    {
        VistaAlMar = vistaAlMar;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Tipo: Habitación Doble, Vista al mar: {VistaAlMar}");
    }
}
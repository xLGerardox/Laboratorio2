public class HabitacionSimple : Habitacion
{
    public int NumeroDeCamas { get; set; }

    public HabitacionSimple(int numero, double precioPorNoche, int numeroDeCamas)
        : base(numero, precioPorNoche)
    {
        NumeroDeCamas = numeroDeCamas;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Tipo: Habitación Simple, Número de camas: {NumeroDeCamas}");
    }
}
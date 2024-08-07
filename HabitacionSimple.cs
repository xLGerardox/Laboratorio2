public class HabitacionSimple : Habitacion
{
    public int NumeroDeCamas { get; set; }

    public HabitacionSimple(int numero, double precioPorNoche, int numeroDeCamas)
        : base(numero, precioPorNoche)
    {
        NumeroDeCamas = numeroDeCamas;
    }
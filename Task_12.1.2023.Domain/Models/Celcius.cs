namespace Task_12._1._2023.Domain.Models;
public partial class Celcius
{
    public double Degree { get; set; }
}

public partial class Celcius
{
    public Celcius(double degree)
    {
        Degree = degree;
    }

    public static implicit operator Kelvin(Celcius degree)
    {
        return new Kelvin(273.15 + degree.Degree);
    }
}

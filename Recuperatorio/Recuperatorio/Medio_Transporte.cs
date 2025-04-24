using System;

public class Medio_Transporte
{
    protected string nombre;

    protected string max_pasajeros;

    protected string caracteristica;

    public Medio_Transporte()
	{
	}

    public virtual void avanzar()
    {
        Console.WriteLine($"Nombre: {this.nombre}//Caracteristica: {caracteristica}");
    }
}

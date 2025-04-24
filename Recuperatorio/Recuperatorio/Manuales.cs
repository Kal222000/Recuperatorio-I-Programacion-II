using System;

public class Manuales : Medio_Transporte
{
    private string fuente = "Manual";

    private string equipo_seguridad;
    public Manuales(string nombre, string pasajeros, string caracteristica, string equipo)
	{
        this.nombre = nombre;
        this.max_pasajeros = pasajeros;
        this.caracteristica = caracteristica;
        this.equipo_seguridad = equipo;
    }

    public override void avanzar()
    {
        Console.WriteLine($"Nombre: {this.nombre}//Caracteristica: {this.caracteristica}//Fuente de energia: {this.fuente}");
    }
}

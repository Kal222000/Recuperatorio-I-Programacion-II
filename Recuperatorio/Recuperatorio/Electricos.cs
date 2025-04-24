using System;

public class Electricos : Medio_Transporte
{

    private string fuente = "Energia Electrica";

    private string tipo_bateria;

    public Electricos(string nombre, string pasajeros, string caracteristica, string bateria)
	{
        this.nombre = nombre;
        this.max_pasajeros = pasajeros;
        this.caracteristica = caracteristica;
        this.tipo_bateria = bateria;
    }

    public override void avanzar()
    {
        Console.WriteLine($"Nombre: {this.nombre}//Caracteristica: {this.caracteristica}//Fuente de energia: {this.fuente}");
    }
}

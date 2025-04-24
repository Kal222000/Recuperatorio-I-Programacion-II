using System;

public class Combustibles_Fosiles : Medio_Transporte
{
    private string fuente = "Combustibles Fosiles";

    private string nivel_de_contaminacion;

    public Combustibles_Fosiles(string nombre, string pasajeros, string caracteristica, string contaminacion)
	{
		this.nombre = nombre;
		this.max_pasajeros = pasajeros;
		this.caracteristica = caracteristica;
        this.nivel_de_contaminacion = contaminacion;
    }

    public override void avanzar()
    {
        Console.WriteLine($"Nombre: {this.nombre}//Caracteristica: {this.caracteristica}//Fuente de energia: {this.fuente}");
    }
}

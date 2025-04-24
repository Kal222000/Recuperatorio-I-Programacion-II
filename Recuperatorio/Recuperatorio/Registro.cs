using System;

public class Registro
{
	private Medio_Transporte[] papeles;

	private int cantidad_registrada;
	public Registro(int n)
	{
		this.papeles = new Medio_Transporte[n];
		this.cantidad_registrada = -1;
	}

    public void registrar()
	{
        if(this.cantidad_registrada == this.papeles.Length)
        {
            Console.WriteLine("No se pueden registrar mas vehiculos");
            return;
        }
        string a = Console.ReadLine();
		Console.WriteLine("Ingrese los datos");
        if (a[0] == '1')
        {
            string b, c, d, e;
            Console.WriteLine("Nombre:");

            b = Console.ReadLine();

            Console.WriteLine("Cantidad maxima de pasajeros:");

            c = Console.ReadLine();

            Console.WriteLine("Caracteristica:");

            d = Console.ReadLine();


            Console.WriteLine("Nivel de Contaminacion:");

            e = Console.ReadLine();

            Medio_Transporte medio = new Combustibles_Fosiles(b, c, d, e);
            this.cantidad_registrada += 1;
            this.papeles[this.cantidad_registrada] = medio;

        }
        else if (a[0] == '2')
        {
            string b, c, d, e;

            Console.WriteLine("Nombre:");

            b = Console.ReadLine();

            Console.WriteLine("Cantidad maxima de pasajeros:");

            c = Console.ReadLine();

            Console.WriteLine("Caracteristica:");

            d = Console.ReadLine();

            Console.WriteLine("Tipo de Bateria:");

            e = Console.ReadLine();

            Medio_Transporte medio = new Electricos(b, c, d, e);
            this.cantidad_registrada += 1;
            this.papeles[this.cantidad_registrada] = medio;
        }
        else if (a[0] == '3')
		{
            string b, c, d, e;

            Console.WriteLine("Nombre:");

            b = Console.ReadLine();

            Console.WriteLine("Cantidad maxima de pasajeros:");

            c = Console.ReadLine();

            Console.WriteLine("Caracteristica:");

            d = Console.ReadLine();

            Console.WriteLine("Equipo de Seguridad con el que cuenta:");

            e = Console.ReadLine();

            Medio_Transporte medio = new Manuales(b, c, d, e);
            this.cantidad_registrada += 1;
            this.papeles[this.cantidad_registrada] = medio;
        }
		else { 
            Console.WriteLine("Debe Ingresar un valor valido"); 
            return; 
        }
	}

    public void Moverse()
    {
        if(this.cantidad_registrada == -1)
        {
            Console.WriteLine("No se han registrado vehiculos");
            return;
        }
        else
        {
            for(int i = 0; i <= this.cantidad_registrada; i++)
            {
                Console.WriteLine($"{i + 1}. ");
                this.papeles[i].avanzar();
            }
        }
    }
}

Console.WriteLine("Bienvenido al Sistema de Registro");
Console.WriteLine("Ingrese la cantidad maxima de medios de transporte que desea registrar");
int n = int.Parse(Console.ReadLine());
Registro reg = new Registro(n);
bool aux = true;
while (aux)
{
    Console.WriteLine("1. Agregar Registro || 2. Mostrar Vehiculos || 3. Salir");
    string a = Console.ReadLine();
    if (a[0] == '1')
    {
        Console.WriteLine("Modelos de Transporte: 1. Combustibles Fosiles || 2. Electricos || 3. Manuales");
        reg.registrar();
    }
    if (a[0] == '2')
    {
        reg.Moverse();
    }
    if (a[0] == '3')
    {
        aux = false;
    }
    else
    {
        Console.WriteLine("Comando Equivocado");
    }
}
Console.WriteLine("Saliendo del Sistema");

using _32_Rhombus;

try
{
    Console.Write("Ingrese el tamaño del rombo: ");
    var size = Console.ReadLine();
    var rhombus = new Rhombus(int.Parse(size!));
    rhombus.Draw();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
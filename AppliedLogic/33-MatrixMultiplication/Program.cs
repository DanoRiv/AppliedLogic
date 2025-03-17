using _33_MatrixMultiplication;

try
{
    Console.Write("Ingrese el valor de m: ");
    var m = Console.ReadLine();
    Console.Write("Ingrese el valor de n: ");
    var n = Console.ReadLine();
    Console.Write("Ingrese el valor de p: ");
    var p = Console.ReadLine();
    
    var matrix = new Matrix(int.Parse(m!), int.Parse(n!), int.Parse(p!));
    matrix.Print();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
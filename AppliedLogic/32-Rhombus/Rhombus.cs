namespace _32_Rhombus;

public class Rhombus
{
    private int _size;

    public Rhombus(int size)
    {
        Size = size;
    }

    public int Size { get => _size; set => _size = ValidateSize(value); }

    public void Draw()
    {
        string[][] rhombus = new string[Size][];
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (rhombus[i] == null)
                {
                    rhombus[i] = new string[Size];
                }
                rhombus[i][j] = " ";
            }
        }
        for (int i = 0; i <= Size / 2; i++)
        {
            rhombus[i][Size / 2 - i] = "#";
            rhombus[i][Size / 2 + i] = "#";
            rhombus[Size - i - 1][Size / 2 - i] = "#";
            rhombus[Size - i - 1][Size / 2 + i] = "#";
        }
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Console.Write(rhombus[i][j]);
            }
            Console.WriteLine();
        }
    }

    private int ValidateSize(int size)
    {
        if (size < 1)
        {
            throw new Exception("El tamaño del rombo debe ser mayor a 1");
        }
        if (size % 2 == 0)
        {
            throw new Exception("El tamaño del rombo debe ser impar");
        }
        return size;
    }
}
namespace JSharp01.N01_DataType;

public class Ex06_Random
{
    public static void Main()
    {
        Random random = new Random();
        int x = random.Next(0, 10);
        int y = random.Next(0, 10);
        
        Console.WriteLine("{0} {1}", x, y);
    }
}
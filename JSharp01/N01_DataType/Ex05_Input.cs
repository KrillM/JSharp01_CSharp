namespace JSharp01.N01_DataType;

public class Ex05_Input
{
    public static void Main()
    {
        Console.WriteLine("이름을 입력하세요.");
        string name = Console.ReadLine();
        
        Console.WriteLine("나이를 입력하세요.");
        int age = int.Parse(Console.ReadLine());
        
        Console.WriteLine("이름: {0}\n나이: {1}", name, age);
    }
}
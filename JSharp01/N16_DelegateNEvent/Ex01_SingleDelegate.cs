namespace JSharp01.N16_DelegateNEvent;

public delegate void BasicDelegate(int number, string name);

public class Ex01_SingleDelegate
{
    static void Number(int number, string name)
    {
        
    }

    static void Name(int number, string name)
    {
        
    }

    static void Player(int number, string name)
    {
        Console.WriteLine("#{0}: {1}", number, name);
    }

    public static void main()
    {
        BasicDelegate player = Player;
        player += Number;
        player += Name;
        
        Player(10, "Messi");
        Player(7, "Son");
        player(9, "Halland");
    }
}
namespace JSharp01.N06_Inherit;

class A
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}

class B : A
{
    /// <summary>
    /// 상속을 받을 때 자료형 앞에 new를 작성한다.
    /// </summary>
    public new string Name
    {
        get;
        set;
    }

    public new int Age
    {
        get;
        set;
    }
}

public class Ex03_Property
{
    public static void Main()
    {
        A a = new A();
        a.Name = "Krille";
        a.Age = 25;
        
        Console.WriteLine(a.Name);
        Console.WriteLine(a.Age);
        
        B b = new B();
        b.Name = "Yena";
        b.Age = 22;
        
        Console.WriteLine(b.Name);
        Console.WriteLine(b.Age);
    }
}
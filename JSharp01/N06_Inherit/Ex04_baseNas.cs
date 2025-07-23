namespace JSharp01.N06_Inherit;

class C
{
    public string name = "c";
    
    public C()
    {
        Console.WriteLine("C 생성자");
    }

    public C(string name)
    {
        this.name = name;
    }

    public void print()
    {
        Console.WriteLine("C");
    }
}

class D : C
{
    public string name = "d";
    
    /// <summary>
    /// 자바는 생성자 내부에서 super()를 사용하나 C#에서는 base를 상속받아 사용한다.
    /// </summary>
    public D() : base("Charlie")
    {
        Console.WriteLine("D 생성자");
    }

    public void print()
    {
        base.print();
        Console.WriteLine("D");
        
        Console.WriteLine(base.name);
        Console.WriteLine(name);
    }
}

class E
{
}

public class Ex04_baseNas
{
    public static void Main()
    {
        C c = new C();
        c.print();

        D d = new D();
        d.print();
        
        if(d is C) Console.WriteLine("True");
        else Console.WriteLine("False");
        
        E e = new E();
        if(e is D) Console.WriteLine("True");
        else Console.WriteLine("False");
    }
}
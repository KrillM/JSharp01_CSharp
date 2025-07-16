namespace JSharp01.N01_DataType;

public class Ex01_DataType
{
    public static void main()
    {
        const int x = 100;
        // readonly도 있으나 심화과정 단계라 생략함
        
        // string, bool에서 Java와 다르게 사용하는 C#
        string word = "Hello C#";
        Console.WriteLine(word);
        
        // 그렇다고 String이 사용 안 되는 것이 아니다.
        String Wow = word + " and Java";
        System.Console.WriteLine(Wow);
        
        // string: 변수 선언 때
        // String: 정적 메소드나 상수에 접근할 때
        const string StickWord = "Stone";
        bool isEmpty = string.IsNullOrEmpty(StickWord);
        Console.WriteLine(isEmpty);

        bool isCSharp = true;
        Console.WriteLine(isCSharp);
        Console.WriteLine(!isCSharp);
        
    }
}
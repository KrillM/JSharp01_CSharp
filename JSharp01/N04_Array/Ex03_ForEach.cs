namespace JSharp01.N04_Array;

public class Ex03_ForEach
{
    public static void main()
    {
        int[]x = new int[] { 1, 2, 3, 4, 5 };

        // var는 초기화 값이 명확할 때만 쓰는 타입 추론 키워드로,
        // 간결성과 익명 타입 처리, LINQ 결과 처리에 매우 유용하다.
        foreach (var i in x)
        {
            Console.Write("{0} ", i);
        }
    }
}
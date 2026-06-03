using System;
using System.Linq;

// ------------------------------------------
// 가변장 인수 ( param 키워드 )

var median1 = MathUtils.Median(3, 5, 8, 3, 7);
var median2 = MathUtils.Median(3, 4, 7, 3, 5, 9, 1, 6);
var median3 = MathUtils.Median(new[] { 4.0, 5, 3, 8, 9, 2 , 1 });
// 가변인수의 형은 배열이다.
Console.WriteLine(median1);
Console.WriteLine(median2);
Console.WriteLine(median3);

public static class MathUtils
{
    // 중앙값 구함.
    public static double Median(params double[] args)
    {
        var sorted = args.OrderBy(n => n).ToArray();
        int index = sorted.Length / 2;
        if (sorted.Length % 2 == 0)
            return (sorted[index] + sorted[index - 1]) / 2.0;
        else
            return sorted[index];
    }
}
// 5
// 4.5
// 4
// ------------------------------------------
// 메소드를 식형식으로 작성.("=>"연산자 사용)
// 메소드가 한줄일 경우.
public int GetPrice() => UnitPrice * Quantity;

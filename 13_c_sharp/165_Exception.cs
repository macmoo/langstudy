using System;

namespace Gihyo
{
    class Program
    {
        static void Main()
        {
            try
            {
                var win = 0;
                var lose = 0;
                var rate = GetRate(win, lose);
            }
            catch (DivideByZeroException e)
            {
                // ここに例外発生時の処理を書く。
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Source: {e.Source}"); // 예외의 원인이된 오브젝트 이름
                Console.WriteLine($"TargetSite: {e.TargetSite}"); // 예외를 던진 메소드
                Console.WriteLine($"StackTrace: {e.StackTrace}");
            }
        }
        static int GetRate(int win, int lose)
        {
            return (win / (win + lose)) * 100;
        }
    }
}


// Message: Attempted to divide by zero.
// Source: Recipe_2605
// TargetSite: Int32 GetRate(Int32, Int32)
// StackTrace: at Gihyo.Program.GetRate(Int32 win, Int32 lose) in C:\_dev\_git\_langstudy\13_c_sharp\Recipe_2605\Recipe_2605\165_Exception.cs:line 26
//    at Gihyo.Program.Main() in C:\_dev\_git\_langstudy\13_c_sharp\Recipe_2605\Recipe_2605\165_Exception.cs:line 13

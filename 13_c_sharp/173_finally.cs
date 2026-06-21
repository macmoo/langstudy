using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("처리 실행");
            return; // return 해도 finally블록은 실행됨.
        }
        finally
        {
            Console.WriteLine("후속처리를 실행");
        }
    }
}

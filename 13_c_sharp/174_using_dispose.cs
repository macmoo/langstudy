using System;
using System.Reflection.PortableExecutable;

// ------------------------------------------
// using문
//
// using (var 변수 = new 형(---))
// {} 
//
// IDisposal인터페이스를 구현한 클래스를 이용할 때는,
// 사용이 끝나면 Dispose()로 그 오브젝트를 파기할 필요가 있다.
// using문을 쓰면 Dispose()를 명시적으로 부르지 않아도 
// 확실히 오브젝트를 파기할 수 있다.

class Program
{
    static void Main(string[] args)
    {
        // 방법.1
        using ( var reader = new StreamReader("example.txt"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
        // 방법.2 = 방법1과 같다.
        var reader2 = new StreamReader("example.txt");
        try
        {
            while (!reader2.EndOfStream)
            {
                var line = reader2.ReadLine();
                Console.WriteLine(line);
            }
        }
        finally
        {
            reader2.Dispose();
        }

        // 방법.3 
        // Main()가 끝날때 reader3의 Dispose()가 호출됨.
        using var reader3 = new StreamReader("example.txt");
        while (!reader3.EndOfStream)
        {
            var line = reader3.ReadLine();
            Console.WriteLine(line);
        }
    }
}

// using문을 연속시켜서 하나의 블록내에서 처리하게 하는 것도 가능.
// using (var input = new StreamReader("input.txt"))
// using (var output = new StreamReader("output.txt"))
// {}

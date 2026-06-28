using System;

// ------------------------------------------
//
// 인터페이스
//
// - 인터페이스를 사용하면, 클래스가 구현해야한 메소드나 프로퍼티를 규정할 수 있다.
//
// - 인터페이스를 구현하는 클래스는 반드시 인터페이스가 정의한
//   메소드, 프로퍼티를 정의 해야한다.

// ------------------------------------------
// 인터페이스 정의
//
// 액세스수식자 interface 인터페이스명
// {
//     메소드 / 프로퍼티 선언
// }
//

// ------------------------------------------
// 인터페이스 구현
//
// 액세스수식자 class 클래스 : 인터페이스명
// {
//     인터페이스에서 선언한 메소드나 프로퍼티의 정의
//     클래스 독자의 멤버 정의
// }


// ------------------------------------------
var obj = new SampleClass();
obj.Repeat("+", 5);
Console.WriteLine(obj.RepeatCount);

// 인터페이스 정의
public interface IPepeatable
{
    void Repeat(object item, int num);
    int RepeatCount { get; }
}

// 인터페이스 구현
public class SampleClass : IPepeatable
{
    public void Repeat(object item, int num)
    {
        for (var i = 0; i < num; i++)
        {
            Console.Write(item.ToString());

        }
        Console.WriteLine();
        RepeatCount = num;
    }
    public int RepeatCount { get; private set; }
}

// +++++
// 5
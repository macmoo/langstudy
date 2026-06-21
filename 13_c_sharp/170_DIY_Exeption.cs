using System;

// ------------------------------------------
//
// 자작 Exception
// - Exception클래스를 상속.
// - 클래스명은 반드시 ..Exception로 끝날것.
// - 3가지 생성자 필요
//   1. 인수없는 생성자
//   2. 문자열 메시지를 받는 생성자
//   3. 문자열 메시지와 내부예외를 받는 생성자
// - 되도록 이미 정의되어 있는 Exception을 사용할것.
//
try
{
    throw new MyAppException("예외 발생");
}
catch(MyAppException e)
{
    Console.WriteLine(e.Message);
}

// 독자 예외 클래스
public class MyAppException : Exception
{
    //   1. 인수없는 생성자
    public MyAppException() { }

    //   2. 문자열 메시지를 받는 생성자
    public MyAppException(string message) : base(message) { }

    //   3. 문자열 메시지와 내부예외를 받는 생성자
    public MyAppException(string message, Exception inner) : base(message, inner) { }
}
// 예외 발생
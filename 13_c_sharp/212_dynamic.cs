using System;

// dynamic형은 컴파일시에 정적인 형체크가 우회되어
// 모든 조작이 서포트되는 것으로 간주된다.
// 만약, 그 조작이 무효한 경우에는 실행시에 예외 발생.

// 계승관계가 아닌 클래스의 오브젝트를 인수로 받음.
static void DynamicSample(dynamic obj)
{
    obj.Execute("Hello");
}

DynamicSample(new ExampleClass1());
DynamicSample(new ExampleClass2());

class ExampleClass1
{
    public void Execute(string msg) => Console.WriteLine($"<{msg}>");
}

class ExampleClass2
{
    public void Execute(string msg) => Console.WriteLine($"[{msg}]");
}

// < Hello >
// [Hello]

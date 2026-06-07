using System;

// ------------------------------------------
// access수식자 [readonly] struct 구조체명
// 통상 구조체는 작은 읽기전용 오브젝트를 정의 할 때에 사용.
// 상속불가.
// 인스턴스 필드/프로퍼티의 초기화 불가.
// 인수없는 생성자 불가.
// static구조체 불가.
// 구조체를 정의 할 때는 가능하면 readonly를 붙이는 것이 좋다.
var point = new Point(10, 20);
Console.WriteLine(point.ToString());

public readonly struct Point
{
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"({X},{Y})";
    }
}

// (10, 20)
using System;

// ------------------------------------------
//
// 제너릭 정의
//
// public class 클래스명<T> { ... }
// 
var range = new RangeValue<double>(5.0, 10.0);
Console.WriteLine(range.WithinRange(4));
Console.WriteLine(range.OutOfRange(4));

var range2 = new RangeValue<DateTime>(
    new DateTime(2020, 1, 1), new DateTime(2020, 9, 30));
Console.WriteLine(range2.WithinRange(new DateTime(2020, 5, 10)));
Console.WriteLine(range2.OutOfRange(new DateTime(2020, 5, 10)));

// 제너릭 클래스 정의
// 
// - 정수형일 필요가 없이, 대소비교가 가능한 형이라면 뭐든지 이용할 수 있도록
//   where을 사용하여, 형파라메터 IComparable<T>의 제약을 지정했다.
//   이 경우, T로는 IComparable<T>를 구현한 형만 지정가능.
//   DateTime형도 IComparable<T>를 구현하고 있다.
// - 형파라메터로 인터페이스외에도 struct/class키워드로 값형/참조형을 지정가능.
public class RangeValue<T> where T : IComparable<T>
{
    public RangeValue(T lower, T upper)
    {
        Lower = lower;
        Upper = upper;
    }
    public T Lower { get; }
    public T Upper { get; }

    public bool WithinRange(T value) =>
        Lower.CompareTo(value) <= 0 && value.CompareTo(Upper) <= 0;

    public bool OutOfRange(T value) => !WithinRange(value);
}

// False
// True
// 
// True
// False
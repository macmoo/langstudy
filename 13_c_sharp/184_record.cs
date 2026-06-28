using System;

// ------------------------------------------
// record형
// - 참조형
// - 변경불가
// - 값 기준비교가 가능
// - record형을 정의하는 것으로 안정성이 높은 오브젝트를 정의하는 것이 가능하다.
// - "class" 대신에 "record"를 씀.
// - ToString(), GetHashCode(), ==, != 가 오버라이드되어 있다.

var p1 = new Person("Bill", "Gates");
var p2 = new Person("Bill", "Gates");
var p3 = new Teacher("Bill", "Atkinson", "History");
Console.WriteLine(p1.ToString());
Console.WriteLine(p3.ToString());
Console.WriteLine($"p1 == p2: {p1 == p2}");
Console.WriteLine($"ReferenceEquals(p1, p2): {Object.ReferenceEquals(p1, p2)}");
Console.WriteLine($"p1.GetHashCode(): {p1.GetHashCode()}");
Console.WriteLine($"p1 != p3: {p1 != p3}");
var p4 = p1;
Console.WriteLine($"p1 == p4: {p1 == p4}");
Console.WriteLine($"ReferenceEquals(p1, p4): {Object.ReferenceEquals(p1, p4)}");

// record형 정의
public record Person
{
    public string LastName { get; }
    public string FirstName { get; }

    public Person(string first, string last)
        => (FirstName, LastName) = (first, last);
}

public record Teacher : Person
{
    public string Subject { get; }

    public Teacher(string first, string last, string subject)
        : base(first, last) => Subject = subject;
}

// ------------------------------------------
// 위와 같다.
// public record Person( string FirstName, string LastName);
// public record Teacher(string FirstName, string LastName, string Subject)
//     : Person(FirstName, LastName);

// ------------------------------------------
// Person { LastName = Gates, FirstName = Bill }
// Teacher { LastName = Atkinson, FirstName = Bill, Subject = History }
// p1 == p2: True
// ReferenceEquals(p1, p2): False
// p1.GetHashCode(): 227224652
// p1 != p3: True
// p1 == p4: True
// ReferenceEquals(p1, p4): True

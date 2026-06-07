using System;
using System.Xml.Linq;

// ------------------------------------------
// 익명형이란,
// 클래스를 정의하지 않고 이용가능한 무명의 형(참조형)
// 익명형으로 정의된 프로퍼티는 읽기전용이 된다.

// person은 익명형 오브젝트
var person = new
{
    Name = "사카모토 료마",
    Birthdate = new DateTime(1836, 1, 3)
};

Console.WriteLine($"{person.Name} {person.Birthdate}");
Console.WriteLine(person);

// 사카모토 료마 1836 - 01 - 03 오전 12:00:00
// { Name = 사카모토 료마, Birthdate = 1836 - 01 - 03 오전 12:00:00 }
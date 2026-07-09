// Type.GetProperties()
// Type오브젝트가 나타내는 형의 프로퍼티 리스트를 얻을 수 있다.

using System;
using System.Reflection;


// プロパティの一覧を得る
// DateTime구조체의 public한 인스턴스 프로퍼티를 모두 조사.
var type = typeof(System.DateTime);
var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
foreach (var p in properties)
{
    Console.WriteLine($"{p.Name}, {p.CanWrite}, {p.PropertyType}");
}

// Date, False, System.DateTime
// Day, False, System.Int32
// DayOfWeek, False, System.DayOfWeek
// DayOfYear, False, System.Int32
// Hour, False, System.Int32
// Kind, False, System.DateTimeKind
// Millisecond, False, System.Int32
// Microsecond, False, System.Int32
// Nanosecond, False, System.Int32
// Minute, False, System.Int32
// Month, False, System.Int32
// Second, False, System.Int32
// Ticks, False, System.Int64
// TimeOfDay, False, System.TimeSpan
// Year, False, System.Int32
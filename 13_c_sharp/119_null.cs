using System;

// ------------------------------------------
// null허용형변수 변수 선언
// - 형명? 변수명 = 초기값;
// - null허용형변수로부터 값을 얻기위해서는
//   HasValue프로퍼티로 값이 설정되었는지를 먼저 확인하고
//   Value프로퍼티로 값을 참조
//
// - null허용형 인스턴스는 System.Nullable<T>형이다.
//   다음과 같이 선언도 가능
//
// int? num = null;
// 위와 같다 Nullable<int> num = null;
// 
// Nullable<DateTime> date = null;
int? num = null;

if (num.HasValue)
{
    int val = num.Value;
    Console.WriteLine($"no value:{val}");
}
// Console.WriteLine($"yes value:{num.Value}");
// -> error
// Unhandled exception. System.InvalidOperationException: Nullable object must have a value.
Console.WriteLine();
// ------------------------------------------
// null병합 연산자 ( ?? )
// - left op가 null이 아닌 경우, left op의 값을 반환하고
//   left op가 null인 경우,      right op의 값을 반환한다.
// - 만약 left op값이 null 이 아닌경우, 오른쪽 값을 확인하지 않는다.
int num2 = num ?? -1;
Console.WriteLine($"num2 is {num2}");

int? num3 = 36;
if (num3 is int myVal)
{
    Console.WriteLine($"num3 is {myVal}");
}
else
{
    Console.WriteLine("num3 is null");
}

string encoding = null;
string encoding2 = null;
var text = "인코딩: [" + (encoding ?? encoding2) + "]";
Console.WriteLine(text);
Console.WriteLine();

// ------------------------------------------
// null조건 연산자 ( 식?.멤버 ) 
// - null체크를 생략
// - op가 null이 아닐때만 멤버에 접근이 가능하고, 
//   op가 null일 경우에는 null을 반환
var array = new[]
{
    new {Name = "Strawberris" , Color = "Red"},
    new {Name = "Lemons" , Color = "Yellow"},
    new {Name = "Avocados" , Color = "Green"},
    new {Name = "Blueberries" , Color = "Purple"},
    new {Name = "Oranges" , Color = "Orange"},
};

var item = array.FirstOrDefault(x => x.Color == "White");
var color = item?.Color;
Console.WriteLine($"item.color:[{color}]");
Console.WriteLine();

// ------------------------------------------
// null병합연산자 와 null조건연산자 동시 사용
var color2 = item?.Color ?? "Unknown";
Console.WriteLine($"item.color:[{color2}]");
Console.WriteLine();

// ------------------------------------------
// null병합대입연산자 ( 변수 ??= 식; )
// 특정, 변수가 프로퍼티가 null일 경우, 값을 대입한다.
string msg = null;
msg ??= "Default Message";
Console.WriteLine($"msg:{msg}");
// 위는 아래와 같다.
//if ( msg == null)
//{
//    msg == "Default Message";
//}
// ------------------------------------------
// 
// num2 is -1
// num3 is 36
// 인코딩: []
//
// item.color:[]
//
// item.color:[Unknown]
//
// msg: Default Message

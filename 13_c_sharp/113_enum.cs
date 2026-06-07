using System;

// ------------------------------------------
// enum형
// 내부적으로는 디폴트로 int형.
// public enum BookCategory
// {
//     Other,     // 0
//     Science,   // 1
//     Business,  // 2
//     Novel,     // 3
// }

// 형지정가능
// public enum BookCategory2 : short
// {
//     Other    = 100,
//     Science  = 200,
//     Business = 300,
//     Novel    ,     // <- 301
// }

// ------------------------------------------
// 모든 열거형의 값들을 열거
// Enum.GetValues()
foreach (var val in Enum.GetValues<DayOfWeek>())
{
    Console.Write($"{val} ");
}
Console.WriteLine();
Console.WriteLine();
// Sunday Monday Tuesday Wednesday Thursday Friday Saturday


// ------------------------------------------
// 4를 DayOfWeek형으로 변환
DayOfWeek week = (DayOfWeek)4;
Console.WriteLine(week);

int numweek = (int)week;
Console.WriteLine(numweek);
Console.WriteLine();
// Thursday
// 4

// ------------------------------------------
// 열거형을 문자열로.
var name = Enum.GetName(typeof(DayOfWeek), DayOfWeek.Sunday);
Console.WriteLine(name);

// 문자열에서 열거형으로.
if (Enum.TryParse<DayOfWeek>(name, out var week2))
{
    if (week2 == DayOfWeek.Sunday)
        Console.WriteLine("Sunday");
}

string text2 = DayOfWeek.Sunday.ToString();
Console.WriteLine(text2);
// Sunday
// Sunday
// Sunday

// ------------------------------------------
// public static bool IsDefined(Type enumType, object value);
// ------------------------------------------

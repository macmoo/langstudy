using System;
using System.ComponentModel;
using System.Globalization;

// ------------------------------------------
// public static DateTime Today { get; }

var today_1 = DateTime.Today;
var today_2 = DateTime.Now;
var today_3 = DateTime.UtcNow;

Console.WriteLine(today_1);
Console.WriteLine(today_2);
Console.WriteLine(today_3);
Console.WriteLine();
// ------------------------------------------
var time_1 = new DateTime(2026, 5, 31, 11, 07, 11, 123);
var year_1 = time_1.Year;
var mon_1 = time_1.Month;
var date_1 = time_1.Day;
var hour_1 = time_1.Hour;
var min_1 = time_1.Minute;
var sec_1 = time_1.Second;

Console.WriteLine(time_1);
Console.WriteLine(year_1);
Console.WriteLine(mon_1);
Console.WriteLine(date_1);
Console.WriteLine(hour_1);
Console.WriteLine(min_1);
Console.WriteLine(sec_1);
Console.WriteLine();
// ------------------------------------------
//public DayOfWeek DayOfWeek { get; }
var now_1 = new DateTime(2026, 5, 31, 11, 07, 11, 123);
var dayofweek_1 = now_1.DayOfWeek;
Console.WriteLine($"오늘은 {dayofweek_1} 다.");
Console.WriteLine();
// ------------------------------------------
var now_2 = new DateTime(2026, 5, 31, 11, 07, 11, 123);
var date_2 = now_2.AddDays(5);
var date_3 = now_2.AddDays(-10);
var date_4 = now_2.AddMonths(1);
var date_5 = now_2.AddDays(-3);
Console.WriteLine(date_2);
Console.WriteLine(date_3);
Console.WriteLine(date_4);
Console.WriteLine(date_5);
Console.WriteLine();
// ------------------------------------------
var d_1 = new DateTime(2026, 5, 31);
var d_2 = new DateTime(2026, 6, 1);
Console.WriteLine($"d1:{d_1}");
Console.WriteLine($"d2:{d_2}");
if (d_1 < d_2)
    Console.WriteLine("d1 보다 d2가 최신");
else if(d_1==d_2)
    Console.WriteLine("d1 == d2");
else if (d_1 > d_2)
    Console.WriteLine("d1 가 d2보다 최신");
Console.WriteLine();
// ------------------------------------------
//public static bool IsLeapYear(int year);
var isLeapYear_1 = DateTime.IsLeapYear(2026);
Console.WriteLine(isLeapYear_1 ? "2026은 윤년이다." : "2026은 윤년이 아니다.");
Console.WriteLine();
// ------------------------------------------
// public int DayOfYear { get; }
// puvlic static int DaysInMonth(int year, int month);
// ------------------------------------------
var date_6 = DateTime.Now;
var calendar_6 = new JapaneseCalendar();
var era_6 = calendar_6.GetEra(date_6);
var year_6 = calendar_6.GetYear(date_6);
Console.WriteLine(date_6);
Console.WriteLine(era_6); // 1:메이지, 2:다이세이, 3:쇼와, 4:헤이세이, 5:레이와
Console.WriteLine(year_6);

var culture_6 = new CultureInfo("ja-JP", true);
culture_6.DateTimeFormat.Calendar = calendar_6;
var era_name_6 = culture_6.DateTimeFormat.GetEraName(era_6);
Console.WriteLine(era_name_6);

var str_1 = date_6.ToString("ggy년 M월 d일", culture_6);
Console.WriteLine(str_1);
Console.WriteLine();
// ------------------------------------------
// 2026 - 05 - 31 오전 12:00:00
// 2026 - 05 - 31 오후 11:32:01
// 2026 - 05 - 31 오후 2:32:01

// 2026 - 05 - 31 오전 11:07:11
// 2026
// 5
// 31
// 11
// 7
// 11

// 오늘은 Sunday 다.

// 2026-06-05 오전 11:07:11
// 2026 - 05 - 21 오전 11:07:11
// 2026 - 06 - 30 오전 11:07:11
// 2026 - 05 - 28 오전 11:07:11

// d1: 2026 - 05 - 31 오전 12:00:00
// d2: 2026 - 06 - 01 오전 12:00:00
// d1 보다 d2가 최신

// 2026은 윤년이 아니다.

// 2026-05-31 오후 11:32:01
// 5
// 8
// 令和
// 令和8년 5월 31일
using System;

// ------------------------------------------
//
// Contains()
//
var drinks = new[]
    {"wine","sake","beer","whisky","liqueur","cocktail","champagne"};

var hasWhisky = drinks.Contains("whisky");

Console.WriteLine("whisky가 포함되어 " + (hasWhisky ? "있다." : "있지 않다."));
Console.WriteLine();

// ------------------------------------------
//
// 시퀀스를 배열이나 List<T>로 변환
//
// ToArray
// ToList
//
var dateStrs = new[]
{    "1968/10/23","1912/07/30","1926/12/25","1989/01/08"};

var array = dateStrs.Select(x => DateTime.Parse(x)).ToArray();
Console.WriteLine($"array[0]:{array[0]}");
Console.WriteLine($"요소수:{array.Length}");
Console.WriteLine();
var list = dateStrs.Select(x => DateTime.Parse(x)).ToList();
list.Add(new DateTime(2019, 5, 1));
Console.WriteLine($"요소수:{list.Count}");
Console.WriteLine();
// ------------------------------------------
//
// 딕셔너리로 변환
//
var list2 = new[]
{
    new { Extension = "bat", Description="배치파일"},
    new { Extension = "docx", Description="워드파일"},
    new { Extension = "exe", Description="실행파일"},
    new { Extension = "txt", Description="텍스트파일"},
    new { Extension = "md", Description="마크다운파일"},
};
var dict = list2.ToDictionary(k => k.Extension, v => v.Description);

foreach( var item in dict )
    Console.WriteLine($"{item.Key}:{item.Value}");
Console.WriteLine();
// ------------------------------------------
//
// HashSet로 변환
// HashSet<T>로 변환하는 것으로 IEnumerable<T>보다 빠르게 집합연산이 가능.
//
var fruits1 = new[] { "apple", "banana", "blueberry", "apple" };
var fruits2 = new[] { "banana", "blueberry", "cherry" };

var set1 = fruits1.ToHashSet();
var set2 = fruits2.ToHashSet();
set1.IntersectWith(set2);

foreach(var item in set1)
    Console.WriteLine(item);
// ------------------------------------------
// whisky가 포함되어 있다.
// 
// array[0]:1968 - 10 - 23 오전 12:00:00
// 요소수: 4
// 
// 요소수: 5
// 
// bat: 배치파일
// docx:워드파일
// exe:실행파일
// txt:텍스트파일
// md:마크다운파일
// 
// banana
// blueberry
// 

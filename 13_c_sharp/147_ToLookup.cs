using System;

// ------------------------------------------
//
// ToLookup()
// : 시퀀스내의 요소를 지정한 키로 그룹핑해서 ILookup<K,E>로 변환
//
// - Dictionary<TKey, TValue> : 케애 대응하는 값이 단일값에 할당된다.
// - ILookup<TKey, TElement>  : 키에 대응하는 값이 컬렉션에 할당된다.
//
var books = new[]
{
    new {Title="매니지먼트", Category="Business"},
    new {Title="파우스트", Category="소설"},
    new {Title="생명이란", Category="과학"},
    new {Title="상대론의 의미", Category="과학"},
    new {Title="레미제라블", Category="소설"},
    new {Title="타임머신", Category="소설"},
};
var lookup = books.ToLookup(x => x.Category, x => x.Title);
foreach (var g in lookup)
{
    Console.WriteLine($"{g.Key}");
    foreach(var title in g)
    {
        Console.WriteLine($" # {title}");
    }
 }
Console.WriteLine();
// ------------------------------------------
// Business
// # 매니지먼트
// 소설
//  # 파우스트
//  # 레미제라블
//  # 타임머신
// 과학
//  # 생명이란
//  # 상대론의 의미

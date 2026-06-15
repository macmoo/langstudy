using System;

// ------------------------------------------
//
// GroupBy : 지정한 키 셀렉터함수로 시퀀스의 요소를 그룹화한다.
//
// ToLookUp()과 같은 결과를 만듬.
// 차이:ToLookUp()은 즉시실행메소드, GroupBy()은 지연실행메소드.
//      대부분의 경우 GroupBy()가 유리
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

var group = books.GroupBy(x => x.Category);

foreach ( var g in group)
{
    Console.WriteLine($"#{g.Key}");
    foreach( var b in g)
    {
        Console.WriteLine($" {b.Title}");
    }
}
// ------------------------------------------
// # Business
//  매니지먼트
// # 소설
//  파우스트
//  레미제라블
//  타임머신
// # 과학
//  생명이란
//  상대론의 의미
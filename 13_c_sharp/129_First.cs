using System;
//
// https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.first?view=net-10.0#system-linq-enumerable-first-1(system-collections-generic-ienumerable((-0)))
// ------------------------------------------
// 최초의 요소 취득
// ------------------------------------------
// First : 요소가 발견되지 않으면 InvalidOperaionException발생
// FirstOrDefaul : 예외발생없이 요소의 형의 디폴트값/null 을 반환.
// 
var names = new[] { "Apple", "Microsoft", "Google", "Oracle", "Facebook", "Adobe", "Amazon" };
var name1 = names.First();
var name2 = names.FirstOrDefault();

Console.WriteLine(name1);
Console.WriteLine(name2 ?? "<Not Found>");

// Apple
// Apple

// ------------------------------------------
// Func<TSource, bool>델리게이트를 받는 메소드도 있다.
//
var name3 = names.First(n => n.Length > 8);
var name4 = names.FirstOrDefault(n => n.Length > 10);

Console.WriteLine(name3);
Console.WriteLine(name4 ?? "<Not Found>");

// Microsoft
// <Not Found>

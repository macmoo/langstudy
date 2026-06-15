using System;

// ------------------------------------------
// Join:지정한 키로 두개의 시퀀스를 관련지음.
//
var teachers = new[]
{
    new {Id=10, Name="다카하시 선생"},
    new {Id=14, Name="미하시 선생"},
    new {Id=26, Name="요시하라 선생"},
};

var coureses = new[]
{
    new {Title="수학원론", TearcherId=10 },
    new {Title="수론", TearcherId=10 },
    new {Title="기하학1", TearcherId=14 },
    new {Title="기하학2", TearcherId=14 },
    new {Title="미분,적분", TearcherId=26 },
};

// join할 키는 teachers.Id와 coureses.TearcherId
var query = teachers.Join(coureses,
                            t => t.Id,
                            c => c.TearcherId,
                            (t, c) => new { t.Id, t.Name, c.Title });

foreach(var item in query)
{
    Console.WriteLine($"{item.Id} {item.Name} {item.Title}");
}
Console.WriteLine();

// 복수의 프로퍼티를 키로 하고싶을 때는.
// var query2 = salesdetail.Join(product,
//                             s => new {s.Code, s.Color},
//                             p => new {p.Code, p.Color},
//                             (s, p) => new { .... });

// ------------------------------------------
// 10 다카하시 선생 수학원론
// 10 다카하시 선생 수론
// 14 미하시 선생 기하학1
// 14 미하시 선생 기하학2
// 26 요시하라 선생 미분, 적분

// ------------------------------------------
// GroupJoin:지정한 키로 두개의 시퀀스를 관련지음.
// - Join()과 GroupBy()를 합친것같은 메소드.
//
// GroupJoin()의 4번째 인수로 하나의 Teacher와 복수의 Courses의 프로퍼티를 갖는
// 무명객체를 생성.
// 이 무명객체의 시퀀스가 GroupJoin()의 반환값
var query2 = teachers.GroupJoin(coureses,
                                    t => t.Id,
                                    c => c.TearcherId,
                                    (t, cs) => new { Teacher = t, Courses = cs });

foreach (var group in query2)
{
    Console.WriteLine(group.Teacher.Name);
    foreach (var c in group.Courses)
    {
        Console.WriteLine($"  {c.Title}");
    }
}

// ------------------------------------------
// 10 다카하시 선생 수학원론
// 10 다카하시 선생 수론
// 14 미하시 선생 기하학1
// 14 미하시 선생 기하학2
// 26 요시하라 선생 미분, 적분

// ------------------------------------------
// 다카하시 선생
//   수학원론
//   수론
// 미하시 선생
//   기하학1
//   기하학2
// 요시하라 선생
// 미분, 적분

using System;
using static System.Collections.Specialized.BitVector32;

var persons = new List<Person>
{
        new Person { Name = "사카모토", SectionCode = 1 },
        new Person { Name = "요시다", SectionCode = 2 },
        new Person { Name = "이토이", SectionCode = 3 },
        new Person { Name = "케이코", SectionCode = 1 },
        new Person { Name = "도쿠가와", SectionCode = 2 },
        new Person { Name = "오오쿠보", SectionCode = 4 },
};
var sections = new List<Section>
{
        new Section { Code = 1, SectionName = "영업부" },
        new Section { Code = 2, SectionName = "총무부" },
        new Section { Code = 3, SectionName = "제조부" },
        new Section { Code = 0, SectionName = "기획부" },
};

var query = persons.GroupJoin(sections,
                                p => p.SectionCode,
                                s => s.Code,
                                (p, ps) => new { p, ps })
                   .SelectMany(x => x.ps.DefaultIfEmpty(),
                                (x, s) => new { Name = x.p.Name, Section = s == null ? "(none)" : s.SectionName });
foreach(var p in query)
{
    Console.WriteLine("{0}:{1}", p.Name, p.Section);
}


public class Person
{
    public string Name { get; set; }
    public int SectionCode { get; set; }
}

public class Section
{
    public int Code { get; set; }
    public string SectionName { get; set; }
}

// 사카모토:영업부
// 요시다:총무부
// 이토이:제조부
// 케이코:영업부
// 도쿠가와:총무부
// 오오쿠보:(none)
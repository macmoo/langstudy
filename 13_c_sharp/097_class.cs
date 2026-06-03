using System;
using System.Runtime.CompilerServices;

// ------------------------------------------
// public   : 임의의 코드에서 접근가능
// internal : 같은 어셈블리내의 임의의 코드에서 접근가능
// private  : 入れ子になってクラスで、そのクラス内でアクセス可能
// 
// public 형명 프로퍼티명 { get; set; }
// get/set 억세서를 준비한 프로퍼티는 통상의 변수처럼 값의 취득/설정이 가능.
var person = new GreatPerson();
person.Name = "알랑 들롱";
person.Birthdate = new DateTime(1999, 1, 2);
Console.WriteLine($"{person.Name} {person.Birthdate}");
// ------------------------------------------
public class GreatPerson
{
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
}
// ------------------------------------------
var person2 = new GreatPerson2("마틴", "스콜세지", new DateTime(2001, 11, 22));
Console.WriteLine($"{person2.Name} {person2.Birthdate}");
public class GreatPerson2
{
    // 동일 클래스내 값 변경 가능
    public string FamilyName { get; private set; }
    public string GivenName { get; private set; }
    // 값 변경 불가
    public string Name => FamilyName + GivenName;
    // == public string Name { get { return FamilyName + GivenName; } }
    // 생성자 안에서 값 변경 가능
    public DateTime Birthdate { get; }

    public GreatPerson2(string familyname, string givenname, DateTime birthdate)
    {
        FamilyName = familyname;
        GivenName = givenname;
        Birthdate = birthdate;
    }
}
// ------------------------------------------
// 프로퍼티 초기값 설정
// public 형명 프로퍼티명 { get; set; } = 초기값;
public class Todo
{
    public string Title { get; set; } = String.Empty;
    public bool Finished { get; set; } = false;
    public DateTime CreateAt { get; } = DateTime.Now;
    public DateTime DeadLine { get; set; } = DateTime.Now.AddDays(7);
}
// ------------------------------------------
// backing필드
// public 프로퍼티로 공개된 데이터를 설정하는 private필드를 backing필드라고 함.
var person3 = new GreatPerson3();
person3.Name = "폰.노인만";
person3.Birthdate = new DateTime(1903, 12, 28);
Console.WriteLine($"{person3.Name} {person3.Birthdate:d}");
public class GreatPerson3
{
    // backing필드
    private string _name;
    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("null이나 공백문자는 대입할 수 없다.");
            _name = value;
        }
    }
    public DateTime Birthdate { get; set; }
}
// ------------------------------------------
//알랑 들롱 1999 - 01 - 02 오전 12:00:00
//마틴스콜세지 2001-11-22 오전 12:00:00
//폰.노인만 1903 - 12 - 28

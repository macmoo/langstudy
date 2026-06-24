using System;
using System.Dynamic;
using System.Collections.Generic;

// 利用例
dynamic obj = new DynamicDataObject();
obj.Name = "出井";
obj.City = "宇都宮";
obj.HireDate = new DateTime(2020, 4, 1);
Console.WriteLine($"{obj.Name}: {obj.Name.GetType().Name}");
Console.WriteLine($"{obj.City}: {obj.City.GetType().Name}");
Console.WriteLine($"{obj.HireDate:D}: {obj.HireDate.GetType().Name}");
Console.WriteLine(obj.IsDefined("City"));

// DynamicObject를 상속하는 것으로 동적으로 프로퍼티를 추가할 수 있는 
// 클래스의 정의가 가능하다.
// 動的にプロパティを追加できるクラス
public class DynamicDataObject : DynamicObject
{
    // 동적으로 추가한 프로퍼티와 값을 관리.
    private Dictionary<string, object> _data = new Dictionary<string, object>();

    // 오버라이드
    public override bool TryGetMember(GetMemberBinder binder, out object result)
        => _data.TryGetValue(binder.Name, out result);

    // 오버라이드
    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
        _data[binder.Name] = value;
        return true;
    }

    public bool IsDefined(string propertyName)
        => _data.ContainsKey(propertyName);
}

// 出井: String
// 宇都宮: String
// 2020년 4월 1일 수요일: DateTime
// True
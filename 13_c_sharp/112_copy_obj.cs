using System;
using System.Net.Http.Headers;
using System.Net.WebSockets;

// ------------------------------------------
// protected object MemberwiseClone();
// 오브젝트의 간이복사(샬로우카피)
// 복사원의 오브젝트와 같은 형의 인스턴스를 생성해서, 
// 복사원 오브젝트의 비정적필드를 새로운 오브젝트에 복사한다.
// 필드가 참조형일 경우, 참조가 복사되기 때문에 그 필드는 복사원의 오브젝트와
// 같은 오브젝트를 참조하게 된다.


var product = new Product
{
    Name = "스마트 스피커",
    UnitPrice = 9800,
    StartDate = new DateTime(2026, 6, 5)
};

var clone = product.ShallowCopy();
Console.WriteLine(clone.Name);
Console.WriteLine(clone.UnitPrice);
Console.WriteLine(clone.StartDate);
Console.WriteLine();

Console.WriteLine(product.Name);
Console.WriteLine(product.UnitPrice);
Console.WriteLine(product.StartDate);
Console.WriteLine();

class Product
{
    public string Name { get; set; }
    public int UnitPrice { get; set; }
    public DateTime StartDate { get; set; }

    // 오브젝트를 간이복사하는 메소드.
    public Product ShallowCopy() => (Product)this.MemberwiseClone();
}

//스마트 스피커
//9800
//2026-06-05 오전 12:00:00

//스마트 스피커
//9800
//2026-06-05 오전 12:00:00
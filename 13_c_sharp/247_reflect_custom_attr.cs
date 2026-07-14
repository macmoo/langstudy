//
// 독자의 attribute 정의
// 1. System.Attribute클래스를 상속
// 2. AttributeUsage속성을 적용
// 3. 속성 클래스에 생성자 정의(임의)
// 4. 속성 클래스에 프로퍼티 정의(임의)
//
// AttributeUsage속성은 정의하려는 속성의 사용방법을 지정하기위해서 사용한다.
// 클래스에 적용할지, 프로퍼티에 적용할지, 메소드에 적용할지등을 지정.
//

using System;
using System.Reflection;

var product = new Product();
if (product.Name == null &&
    product.Description == null &&
    product.ImageUrl == null)
{
    Console.WriteLine("すべてがnullです");
}
NullToEmptyString(product);
Console.WriteLine($"Name: <{product.Name ?? "null"}>");
Console.WriteLine($"Description: <{product.Description ?? "null"}>");
Console.WriteLine($"ImageUrl: <{product.ImageUrl ?? "null"}>");

// String型のプロパティがnullなら空文字列に変更
// EmptyStringAttributeが適用されているプロパティが対象
static void NullToEmptyString<T>(T value)
{
    var type = value.GetType();
    var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
    foreach (var prop in props)
    {
        if (prop.PropertyType != typeof(string))
            continue;
        if (!prop.CanWrite)
            continue;
        // プロパティにEmptyStringAttributeが適用されているか調べる
        var attr = prop.GetCustomAttribute<EmptyStringAttribute>();
        if (attr == null || attr.Target == false)
            continue;
        // 適用されていて、かつ null ならば、"" に置き換える
        if (prop.GetValue(value) == null)
            prop.SetValue(value, String.Empty);
    }
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int UnitPrice { get; set; }
    [EmptyString(true)]
    public string Description { get; set; }
    [EmptyString(true)]
    public string ImageUrl { get; set; }
}


// AttributeTargets.Property:
//   EmptyStringAttributeは、プロパティだけに適用できる
// AllowMultiple = false:
//   一つのプロパティには、この属性は一つだけ適用できる
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class EmptyStringAttribute : Attribute
{
    // readonlyなので、Targetプロパティは名前付き引数では使用できない
    public bool Target { get; }
    // 属性適用時には、bool型の引数を必ず与える必要がある
    public EmptyStringAttribute(bool target)
    {
        this.Target = target;
    }
}

// すべてがnullです
// Name: < null >
// Description: <>
// ImageUrl: <>

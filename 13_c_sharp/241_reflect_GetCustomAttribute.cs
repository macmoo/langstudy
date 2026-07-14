using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

Type type = typeof(Product);
PrintDisplayName(type, nameof(Product.ProductName));
PrintDisplayName(type, nameof(Product.UnitPrice));

// Display属性のNameプロパティの値をプリントする
static void PrintDisplayName(Type type, string name)
{
    var prop = type.GetProperty(name);
    var attr = prop.GetCustomAttribute<DisplayAttribute>();
    if (attr != null)
    {
        Console.WriteLine($"{name} = {attr.Name}");
    }
}

public class Product
{
    [Display(Name = "상품명")]
    public string ProductName { get; set; }

    [Display(Name = "상품단가")]
    public int UnitPrice { get; set; }
}

// ProductName = 상품명
// UnitPrice = 상품단가

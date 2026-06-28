using System;

// ICustomerを実装したSampleCustomerの利用例
ICustomer cust = new SampleCustomer();
cust.Grade = 2;
var price = 10000 * (1 - cust.DiscountRate());
Console.WriteLine(price);

public interface ICustomer
{
    string Name { get; }
    int Grade { get; set; }

    // 인터페이스에 구현을 추가하는 것이 가능.
    // 既定のインタフェースメソッド라고 함.
    public decimal DiscountRate()
    {
        return Grade switch
        {
            2 => 0.05m,
            3 => 0.1m,
            _ => 0.0m
        };
    }
}

public class SampleCustomer : ICustomer
{
    public string Name { get; set; }
    public int Grade { get; set; }
}
// 9500.00

using System;
using System.Collections.Generic;


Console.WriteLine($"      이름\t값형\t열거형\t배열\t클래스\t제너릭형");
CheckType(10.3);
CheckType("Hello");
CheckType(DayOfWeek.Saturday);
CheckType(new int[4]);
CheckType(new List<int>());


static void CheckType(object obj)
{
    Console.Write($"{obj.GetType().Name,10}");
    var type = obj.GetType();
    Console.Write($"\t{type.IsValueType}");
    Console.Write($"\t{type.IsEnum}");
    Console.Write($"\t{type.IsArray}");
    Console.Write($"\t{type.IsClass}");
    Console.WriteLine($"\t{type.IsGenericType}");
}


// 以下、発展で示したコード
var dict = new Dictionary<int, string>();
Type type = dict.GetType();
foreach (Type arg in type.GenericTypeArguments)
{
    Console.WriteLine(arg.FullName);
}

//        이름     값형    열거형   배열     클래스  제너릭형
//     Double      True    False   False   False   False
//     String      False   False   False   True    False
//  DayOfWeek      True    True    False   False   False
//    Int32[]      False   False   True    True    False
//     List`1      False   False   False   True    True
//------------
// System.Int32
// System.String

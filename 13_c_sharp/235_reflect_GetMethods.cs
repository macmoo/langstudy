using System;
using System.Reflection;

// Type오브젝트의 메소드 리스트를 취득.
// public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr)


var type = typeof(System.Object);
// Object클래스의 public메소드리스트 취득.
var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
foreach (var m in methods)
{
    Console.WriteLine($"{m.Name}, {m.ReturnType}, {m.GetParameters().Length}");
}

// GetType, System.Type, 0
// ToString, System.String, 0
// Equals, System.Boolean, 1
// GetHashCode, System.Int32, 0
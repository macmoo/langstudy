using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

Type type = typeof(MySampleClass);
var attrs = type.GetCustomAttributes();
foreach (var attr in attrs)
    Console.WriteLine(attr);

[Table("MyCustom")]
[Serializable]
[Obsolete]
public class MySampleClass
{
    // .....
}

// System.SerializableAttribute
// System.ComponentModel.DataAnnotations.Schema.TableAttribute
// System.ObsoleteAttribute

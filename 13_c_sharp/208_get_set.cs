using System;

// get, set액세서를 식 형식으로 사용.

var obj = new SampleClass();
obj.Label = null;
Console.WriteLine(obj.Label);

public class SampleClass
{
    private string _label;

    public string Label
    {
        get => _label;
        set => _label = value ?? "Default label";
    }
}
// Default label
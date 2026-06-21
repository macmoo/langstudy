using System;

Execute2();

// -------------------------------------------------------
// null合体条件演算子でthrow式
static void ExampleMethod2(string arg)
{
    var name = arg ?? throw new ArgumentNullException();
}
static void Execute2()
{
    try
    {
        ExampleMethod2(null);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

// Value cannot be null.
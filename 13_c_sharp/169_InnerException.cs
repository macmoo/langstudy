using System;
using System.Collections.Generic;


// Exception클래스의 InnerException프로퍼티는 현재의 예외를 발생시킨
// 근원이 되는 에러정보를 갖고 있는 오브젝트.
try
{
    ThrowExceptionSample();
}
catch (Exception e)
{
    foreach (var ex in GetAllExceptions(e))
    {
        Console.WriteLine(ex.GetType());
    }
}

static IEnumerable<Exception> GetAllExceptions(Exception e)
{
    if (e == null)
    {
        yield break;
    }
    yield return e;
    foreach (var inex in GetAllExceptions(e.InnerException))
    {
        yield return inex;
    }
}

// GetAllExceptionsメソッドのテスト用の例外を発生させる
static void ThrowExceptionSample()
{
    try
    {
        try
        {
            try
            {
                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                throw new NotImplementedException("未実装", e);
            }
        }
        catch (Exception e)
        {
            throw new NotSupportedException("未サポート", e);
        }
    }
    catch (Exception e)
    {
        throw new ApplicationException("アプリ例外", e);
    }
}

// System.ApplicationException
// System.NotSupportedException
// System.NotImplementedException
// System.NullReferenceException


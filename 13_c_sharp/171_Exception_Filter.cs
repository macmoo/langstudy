using System;
using System.Data.SqlClient;

try
{
    // ここで、SqlExceptionが発生
}
catch (SqlException ex) when (ex.Number == 2601)
{
    // when구의 결과가 true인 경우에만 예외 처리.
    // キー重複
    Console.WriteLine("キーが重複しています。" + ex.ToString());
}
catch (SqlException ex)
{
    // キー重複以外のSqlExceptionに関する処理
}
catch (Exception ex)
{
    // その他のすべての例外
}

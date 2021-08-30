using System;

namespace NestedTryDemo
{
    class NestedTryCatchEx
    {
        static void Main(string[] args)
        {
            try
            {
                int num1, num2 = 0;
                num1 = 100 / num2;
                #region Nested try
                try
                {
                    int i = Convert.ToInt32("t");
                    int[] Array = new int[4] { 1, 2, 3, 4 };
                    for (int index = 0; index <= Array.Length; index++)
                    {
                        Console.WriteLine(Array[index]);
                    }

                }
                catch (IndexOutOfRangeException E)
                {
                    Console.WriteLine(E);
                }
                catch (DivideByZeroException E)
                {
                    Console.WriteLine(E);
                }
                finally
                {
                    Console.WriteLine("It will execute either with catch or without catsh");
                }
                #endregion nested try
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

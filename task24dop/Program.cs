// Написать программу для разворота массива
//                  0   1   2   3   4   5   6   7   8   9
// int[] array = { 56, 45, 13, 98, 67, 83, 25, 17, 40};

using System;
 
public class Example
{
    public static void Main()
    {
        int[] array = {56, 45, 13, 98, 67, 83, 25, 17, 40 };
        Array.Reverse(array);
 
        Console.WriteLine(String.Join(',', array));
    }
}

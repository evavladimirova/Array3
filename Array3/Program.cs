using System.Xml.Linq;
using System;
using System.Diagnostics.CodeAnalysis;

int[] n = { 2, 5, 8 };

var sum = SumArr(n);

Console.WriteLine("Sum of all elements stored in the array is: " + sum);

public static int SumArr(int[] n)
{
    var result = 0;
    foreach (var item in n) 
     {
        result += item; 
     }

    return result;
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_FindMax
{
    internal class GenericMethod
    {
        public static void GetMaximum<T>(T Value1, T Value2, T Value3) where T : IComparable //The IComparable interface provides 1method named “CompareTo(Object obj)”
                                                                                             //This method takes an Object as parameter and compares the current instance
                                                                                             //with another object of the same type.Please find the following syntax for it.
                                                                                             //Syntax: int CompareTo(object obj);
        {
            T[] array = new T[] { Value1, Value2, Value3 };
            Array.Sort(array);//Array class in colletions and Sort is method
            Console.WriteLine($"Max value is: {array[2]}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_FindMax
{
    internal class MaxNumberCheck
    {
        public static int MaxIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(firstValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstnumber,secondnumber and thirdnumber are same");
        }
        //uc2 to find maximum float number out of three integers
        public static double MaxFloatNumber(double firstValues, double secondValues, double thirdValues)
        {

            if (firstValues.CompareTo(secondValues) > 0 && firstValues.CompareTo(thirdValues) > 0)
            {
                return firstValues;
            }
            if (secondValues.CompareTo(firstValues) > 0 && secondValues.CompareTo(thirdValues) > 0)
            {
                return secondValues;
            }
            if (thirdValues.CompareTo(firstValues) > 0 && secondValues.CompareTo(firstValues) > 0)
            {
                return thirdValues;
            }
            throw new Exception("firstnumber,secondnumber and thirdnumber are same");
        }
    }
}
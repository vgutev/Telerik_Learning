﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public static class ExtensionMethods
    {
        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i < input.Length; i++)
            {
                result.Append(input[i]);
            }
            return result;
        }
        public static  T Sum1<T>(this IEnumerable<T> enumeration)
        {
            T sum = (dynamic)0;
            foreach (var item in enumeration)
            {
                sum += (dynamic)item;
            }
            return sum;
        }
        public static T Product1<T>(this IEnumerable<T> enumeration)
        {
            T product = (dynamic)1;
            foreach (var item in enumeration)
            {
                product *= (dynamic)item;
            }
            return product;
        }
        public static T Min1<T>(this IEnumerable<T> enumeration)
            where T : IComparable<T>
        {
            T min = enumeration.Last();
            foreach (var item in enumeration)
            {
                if (item.CompareTo(min) <= 0)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T Max1<T>(this IEnumerable<T> enumeration)
            where T : IComparable<T>
        {
            T max = enumeration.Last();
            foreach (var item in enumeration)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T Average1<T>(this IEnumerable<T> enumeration)
        {
            T average = (dynamic)0;
            foreach (var item in enumeration)
            {
                average += (dynamic)item;
            }
            return average/(dynamic)(enumeration.Count());
        }
    }
}

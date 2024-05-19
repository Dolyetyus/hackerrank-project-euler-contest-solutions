using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static void kaprekarNumbers(int p, int q)
    {
        bool invalid = true;
        for (int i = p; i <= q; i++){
            long sqr = (long)i * i;
            string str = sqr.ToString();
            string first = str.Substring(0, str.Length/2);
            string sec = str.Substring(str.Length/2);

            int firstNum = String.IsNullOrEmpty(first) ? 0 : int.Parse(first);
            int secNum = String.IsNullOrEmpty(sec) ? 0 : int.Parse(sec);

            if (firstNum + secNum == i) {
                Console.Write(i + " ");
                invalid = false;
            }
        }

        if (invalid) Console.WriteLine("INVALID RANGE");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}

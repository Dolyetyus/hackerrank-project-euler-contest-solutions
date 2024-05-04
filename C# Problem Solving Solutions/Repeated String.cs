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
    public static long repeatedString(string s, long n)
    {
        long ret = 0;
        
        if (s.Length >= n) {
            for (int i = 0; i<n; i++) if (s[i] == 'a') ret++;
            return ret;
        }
        
        foreach (char c in s) if (c == 'a') ret++;
        ret *= n/s.Length;
        
        if (n%s.Length != 0){
            for (int i = 0; i<n%s.Length; i++) if (s[i] == 'a') ret++;
        };
        
        return ret;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

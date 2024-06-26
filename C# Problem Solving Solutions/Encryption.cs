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
    public static string encryption(string s)
    {
        int min = (int)Math.Floor(Math.Sqrt(s.Length));
        StringBuilder ret = new StringBuilder();
        
        if (s.Length == min*min) {
            min--;
        }
        
        for (int i = 0; i < min + 1; i++){
            for (int ii = i; ii < s.Length+min; ii += min+1){
                if (ii>=s.Length) break;
                ret.Append(s[ii]);
            }
            ret.Append(' ');
        }
        
        return ret.ToString();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

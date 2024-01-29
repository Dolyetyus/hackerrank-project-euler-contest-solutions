using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i<t; i++){
            int n = Convert.ToInt32(Console.ReadLine());
            Calc(n);
        }
    }
    
    static void Calc(int n) {
        BigInteger sum = 1;
        int ret = 0;

        while (n > 0) {
            sum *= n;
            n--;
        }

        string numb = sum.ToString();
        foreach (char digit in numb) {
            ret += digit - '0';
        }

        Console.WriteLine(ret);
    }
}

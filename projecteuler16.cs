using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < t; i++) {
            int n = Convert.ToInt32(Console.ReadLine());
            Calc(n);
        }
    }
    
    static void Calc(int n) {
        BigInteger pow = BigInteger.Pow(2, n);
        string str = pow.ToString();
        int sum = 0;

        foreach (char digit in str) {
            sum += digit - '0';
        }

        Console.WriteLine(sum);
    }
}

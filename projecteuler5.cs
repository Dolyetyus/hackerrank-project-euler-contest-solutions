using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            Calc(n);
        }
    }
    
    static void Calc(int n){
        long result = 1;

        for (int i = 2; i <= n; i++)
        {
            result = LCM(result, i);
        }

        Console.WriteLine(result);
    }
    
    static long GCD(long a, long b){
        while (b != 0){
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static long LCM(long a, long b){
        return (a / GCD(a, b)) * b;
    }
}

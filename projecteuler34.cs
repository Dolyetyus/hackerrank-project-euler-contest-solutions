using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Solution {
    static Dictionary<int, BigInteger> factorialDict;

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        FactorialDict();
        Calc(n);
    }

    static void FactorialDict() {
        factorialDict = new Dictionary<int, BigInteger>();
        for (int i = 0; i <= 9; i++) {
            factorialDict[i] = Factorial(i);
        }
    }

    static void Calc(int n) {
        BigInteger sum = 0;

        for (int i = 10; i < n; i++) {
            if (isCurious(i)) {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }

    static bool isCurious(int n) {
        string numb = n.ToString();
        BigInteger sum = 0;

        foreach (char digit in numb) {
            int fac = digit - '0';
            sum += factorialDict[fac];
        }

        return sum % n == 0;
    }

    static BigInteger Factorial(int n) {
        if (n == 0 || n == 1) {
            return 1;
        }

        BigInteger sum = 1;
        while (n > 0) {
            sum *= n;
            n--;
        }
        return sum;
    }
}

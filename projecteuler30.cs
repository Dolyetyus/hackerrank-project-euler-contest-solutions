using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Calc(n);
    }
    
    static void Calc(int n){
        int upperLimit = (int)Math.Pow(10, 6);
        int res = 0;

        for (int i = 10; i <= upperLimit; i++){
            if (IsSumOfPowers(i, n)){
                res += i;
            }
        }

        Console.WriteLine(res);
    }

    static bool IsSumOfPowers(int num, int n){
        int sum = 0;
        int tempNum = num;

        while (tempNum > 0){
            int digit = tempNum % 10;
            sum += (int)Math.Pow(digit, n);
            tempNum /= 10;
        }

        return sum == num;
    }
}

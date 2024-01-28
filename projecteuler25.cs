using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
//This was one of the hardest "easy" questions
//I could not pass the last test no matter what I did
class Solution {
    static int NumberOfDigits(int n) {
        if (n == 1) {
            return 1;
        }

        double ans = (n * Math.Log10(1.6180339887498948)) - ((Math.Log10(5)) / 2);
        return (int)Math.Ceiling(ans);
    }

    static void Main(String[] args) {
        int testcases = int.Parse(Console.ReadLine());

        while (testcases > 0) {
            int low = 0, high = 25000;
            int n = int.Parse(Console.ReadLine());

            while (low < high) {
                int mid = (low + high) / 2;
                int midN = NumberOfDigits(mid);

                if (midN >= n) {
                    high = mid;
                } 
                else {
                    low = mid + 1;
                }
            }

            Console.WriteLine((low + high) / 2);
            testcases--;
        }
    }
}

/*class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < t; i++) {
            int n = Convert.ToInt32(Console.ReadLine());
            long res = Calc(n);
            Console.WriteLine(res);
        }
    }
    
    static long Calc(int n) {
        long a = 0;
        long b = 1;
        long sum = 0;
        long count = 1;

        while (CountDigits(sum) < n) {
            sum = a + b;
            a = b;
            b = sum;
            count++;
        }

        return count;
    }

    static int CountDigits(long number) {
        int count = 0;
        while (number != 0) {
            number /= 10;
            count++;
        }
        return count;
    }
}*/

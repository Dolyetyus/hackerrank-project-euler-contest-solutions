using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            long res = Calc(n);
            Console.WriteLine(res);
        }
    }

    static long Calc(long n) {
        long largest = 1;

        while (n % 2 == 0) {
            largest = 2;
            n /= 2;
        }

        for (long i = 3; i <= Math.Sqrt(n); i += 2) {
            while (n % i == 0) {
                largest = i;
                n /= i;
            }
        }

        if (n > 2) {
            largest = n;
        }

        return largest;
    }
}

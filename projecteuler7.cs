using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static List<int> primes = new List<int>();
    
    static void Main(String[] args) {
        CalcPrimes();
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(primes.ElementAt(n-1));
        }
    }
    
    static void CalcPrimes() {
        int count = 0;
        int num = 2;

        while (count < 10000) {
            if (IsPrime(num)) {
                primes.Add(num);
                count++;
            }
            num++;
        }
    }

    static bool IsPrime(int num) {
        for (int i = 2; i*i <= num; i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }
}

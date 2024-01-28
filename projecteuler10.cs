using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//My solution was not passing the very last test
//So I'm submitting the optimal solution
class Solution {
    
    static List<int> primes = new List<int>();
    static List<long> sums = new List<long>();
    
    static void Main(String[] args) {
        FindPrimes();
        CalcSum();
        int t = Convert.ToInt32(Console.ReadLine());
        
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            long res = Calc(n);
            Console.WriteLine(res);
        }
    }
    
    static long Calc(int n) {
        int index = primes.BinarySearch(n);
        if (index < 0) {
            index = ~index - 1;
        }

        return sums[index];
    }

    static void FindPrimes() {
        int limit = 1000000;
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++) {
            isPrime[i] = true;
        }

        for (int p = 2; p * p <= limit; p++) {
            if (isPrime[p]) {
                for (int i = p * p; i <= limit; i += p) {
                    isPrime[i] = false;
                }
            }
        }

        for (int i = 2; i <= limit; i++) {
            if (isPrime[i]) {
                primes.Add(i);
            }
        }
    }

    static void CalcSum() {
        long sum = 0;
        foreach (var prime in primes) {
            sum += prime;
            sums.Add(sum);
        }
    }
}

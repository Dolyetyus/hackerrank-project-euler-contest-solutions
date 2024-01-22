using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            uint n = uint.Parse(Console.ReadLine());
            Printnumb(n);
        }
    }
    
    static void Printnumb(uint n)
    {
        long sum = 0;
        n--;

        int sum3 = (3 * (int)((n / 3) * ((n / 3) + 1))) / 2;
        int sum5 = (5 * (int)((n / 5) * ((n / 5) + 1))) / 2;
        int sum15 = (15 * (int)((n / 15) * ((n / 15) + 1))) / 2;

        sum = sum3 + sum5 - sum15;

        Console.WriteLine(sum);
    }
}

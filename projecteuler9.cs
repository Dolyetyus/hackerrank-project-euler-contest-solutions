using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//Solved using the derivation formula
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int m = -1;

            for (int a = 3; a <= n / 3; a++) {
                int b = (n * n - 2 * a * n) / (2 * n - 2 * a);
                int c = n - b - a;

                if (a * a + b * b == c * c) {
                    if (a * b * c > m) {
                        m = a * b * c;
                    }
                }
            }

            Console.WriteLine(m);
        }
    }
}

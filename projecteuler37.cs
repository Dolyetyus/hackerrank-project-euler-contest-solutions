using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static bool IsPrime(int n) {
        if (n == 2) {
            return true;
        }
        if (n % 2 == 0 || n < 2) {
            return false;
        }
        for (int i = 3; i <= Math.Sqrt(n); i += 2) {
            if (n % i == 0) {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int s = 0;

        for (int i = 11; i <= n; i++) {
            if (IsPrime(i)) {
                int t = i;
                
                while (t > 0) {
                    if (!IsPrime(t)) {
                        break;
                    }
                    t = t%(int)Math.Pow(10,(int)Math.Log10(t));
                }

                if (t == 0) {
                    t = i;

                    while (t > 0) {
                        if (!IsPrime(t)) {
                            break;
                        }
                        t = t / 10;
                    }

                    if (t == 0) {
                        s += i;
                    }
                }
            }
        }

        Console.WriteLine(s);
    }
}

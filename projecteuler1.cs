using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main()
    {
        long N, num, three, five, fifteen = 0;
        N = long.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            num = long.Parse(Console.ReadLine());
            three = (num - 1) / 3;
            five = (num - 1) / 5;
            fifteen = (num - 1) / 15;

            Console.WriteLine(3 * (three * (three + 1) / 2) + 5 * (five * (five + 1) / 2) - 15 * (fifteen * (fifteen + 1) / 2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        while (t-- > 0)
        {
            long num = Convert.ToInt64(Console.ReadLine());
            int tn = (int)(num / 1000000000000L);
            int bn = (int)((num / 1000000000L) % 1000);
            int mn = (int)((num / 1000000L) % 1000);
            int th = (int)((num / 1000L) % 1000);
            int hd = (int)(num % 1000);
            if ((tn + bn + mn + th + hd) == 0)
            {
                Console.Write("Zero");
            }
            if (tn > 0)
            {
                Word(tn);
                Console.Write("Trillion ");
            }
            if (bn > 0)
            {
                Word(bn);
                Console.Write("Billion ");
            }
            if (mn > 0)
            {
                Word(mn);
                Console.Write("Million ");
            }
            if (th > 0)
            {
                Word(th);
                Console.Write("Thousand ");
            }
            if (hd > 0)
            {
                Word(hd);
            }
            Console.WriteLine();
        }
    }
    
    static string[] digits = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                              "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

    static string[] tens = {"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

    public static void Word(int num)
    {
        if (num / 100 > 0)
        {
            Console.Write(digits[num / 100] + " Hundred ");
        }
        if ((num % 100) < 20 && (num % 100) > 0)
        {
            Console.Write(digits[num % 100] + " ");
        }
        else if ((num / 10) % 10 > 0)
        {
            Console.Write(tens[(num / 10) % 10] + " ");
            if (num % 10 > 0)
            {
                Console.Write(digits[num % 10] + " ");
            }
        }
    }
}

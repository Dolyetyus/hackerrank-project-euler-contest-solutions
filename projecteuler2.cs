using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            long res = fibonacci(n);
            Console.WriteLine(res);
        }
    }
    
    static long fibonacci(long n){
        long a = 0;
        long b = 1;
        long sum = 0;
        long ret = 0;
        
        while (sum<n){
            sum = a+b;
            if (sum%2==0 && sum<n){
                ret+=sum;
            }
            a=b;
            b=sum;
        }
        
        return ret;
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            long res = calc(n);
            Console.WriteLine(res);
        }
    }
    
    static long calc(int n){
        long first = 0;
        long second = 0;
        
        for (int i = 1; i<=n; i++){
            first+=i;
        }
        first = first*first;
        
        for (int i = 1; i<=n; i++){
            second+=i*i;
        }
        
        return first-second;
    }
}

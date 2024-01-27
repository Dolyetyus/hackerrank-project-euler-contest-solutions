using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string num = Console.ReadLine();
            Calc(n, k, num);
        }
    }
    
    static void Calc(int n, int k, string num){
        int max = 0;
        
        for(int i = 0; i<n-k; i++){
            string temp = num.Substring(i, k);
            int tempmax = 1;
            
            foreach (char chr in temp){
                tempmax *= chr - '0';
            }
            
            if (tempmax>max){
                max=tempmax;
            }
        }
        
        Console.WriteLine(max);
    }
}

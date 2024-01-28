using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class Solution {
    
    static SortedSet<int> palindromes = new SortedSet<int>();
    
    static void Main(String[] args) {
        PalindromesAdd();
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int res = Calc(n);
            Console.WriteLine(res);
        }
    }
    
    static void PalindromesAdd(){
        for (int i = 100; i < 1000; i++){
            for (int ii = 100; ii < 1000; ii++){
                int numb = i * ii;
                string check = numb.ToString();
                string reversedCheck = new string(check.Reverse().ToArray());

                if (check == reversedCheck){
                    palindromes.Add(numb);
                }
            }
        }
    }
    

    
    static int Calc(int n){
        int i = 0;
        
        while (palindromes.ElementAt(i) < n){
            i++;
        }
        
        return palindromes.ElementAt(i-1);
    }
}

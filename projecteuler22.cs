using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        List<string> names = new List<string>();
        for (int i = 0; i < n; i++) {
            names.Add(Console.ReadLine());
        }
        
        names.Sort();
        
        int q = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < q; i++) {
            string name = Console.ReadLine();
            
            for (int ii = 0; ii < names.Count; ii++) {
                if (name == names[ii]){
                    int score = CalculateNameScore(name, ii+1);
                    Console.WriteLine(score);
                    break;
                }
            }
        }
    }

    static int CalculateNameScore(string name, int position) {
        int nameValue = 0;
        
        foreach (char c in name) {
            nameValue += c - 'A' + 1;
        }
        
        return nameValue * position;
    }
}

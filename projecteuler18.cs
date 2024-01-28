using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for (int test = 0; test<cases; test++){
            int t = Convert.ToInt32(Console.ReadLine());
            int[][] triangle = new int[t][];
            int max = 0;
            
            for (int i = 0; i < t; i++) {
                triangle[i] = new int[i + 1];
                string[] numbers = Console.ReadLine().Split();

                for (int ii = 0; ii < numbers.Length; ii++) {
                    triangle[i][ii] = Convert.ToInt32(numbers[ii]);
                }
            }
            
            max = Calc(triangle);
            Console.WriteLine(max);
        }
    }
    
    static int Calc(int[][] triangle) {
        for (int i = triangle.Length - 2; i >= 0; i--) {
            for (int j = 0; j <= i; j++) {
                triangle[i][j] += Math.Max(triangle[i + 1][j], triangle[i + 1][j + 1]);
            }
        }

        return triangle[0][0];
    }
}

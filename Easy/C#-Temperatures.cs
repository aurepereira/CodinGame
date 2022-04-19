// https://www.codingame.com/training/easy/temperatures

// STATEMENT
// Your program must analyze records of temperatures to find the closest to zero.

// SOLUTION
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        int temp = 0;

        for (int i = 0; i < n; i++)
        {
            if (temp == 0) {
                temp = int.Parse(inputs[i]);
            }
            else if (int.Parse(inputs[i]) > 0 && int.Parse(inputs[i]) <= Math.Abs(temp)) {
                temp = int.Parse(inputs[i]);
            }
            else if (int.Parse(inputs[i]) < 0 && - int.Parse(inputs[i]) < Math.Abs(temp)) {
                temp = int.Parse(inputs[i]);
            }
        }

        Console.WriteLine(temp);
    }
}

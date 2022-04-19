// https://www.codingame.com/training/easy/horse-racing-duals

// STATEMENT
// In this problem you have to find the two numbers that are closest to each other among a list of numbers. 
// The list might be really large and force you to search for the best possible algorithmic complexity for your solution.

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
        int N = int.Parse(Console.ReadLine());
        int[] pi = new int[N]; // Create table of dimension N
        int diff = 0; // Initialize variable that will hold smallest difference

        // Insert horse strength values into the array.
        for (int i = 0; i < N; i++)
        {
            pi[i] = int.Parse(Console.ReadLine());
        }

        // Sort array in ascending order.
        Array.Sort(pi);
        for (int i = 0; i < pi.Length; i++) {
            Console.WriteLine(pi[i]);
        }

        // Perform calculations to find the smallest difference.
        // Substract the next adjacent value to the current value.
        for (int i = 0; i < pi.Length - 1; i++) {
            int newDiff = pi[i + 1] - pi[i];
            if (diff == 0) {
                diff = newDiff;
            }
            else {
                diff = Math.Min(diff, newDiff);
            }
        }

        Console.WriteLine(diff);
    }
}

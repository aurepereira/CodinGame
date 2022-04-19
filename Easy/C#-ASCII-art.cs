// https://www.codingame.com/training/easy/ascii-art/solution

// STATEMENT
// The goal of the problem is to simulate an old airport terminal display: your program must display a line of text in ASCII art.
// You have to split strings, store them and recreate others. You can use data structures like arrays or hash tables.

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
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();

        // Define lower and upper bounds
        const int A = (int) 'A';
        const int Z = (int) 'Z';

        // Convert text input to uppercase
        string str = T.ToUpper();

        // Convert input to ASCII
        for (int i = 0; i < H; i++) {

            string row = Console.ReadLine();
            string result = "";

            foreach (var s in str) {
                // Convert string representation to integer
                var c = (int) s;

                if (c < A || c > Z)
                    // If c is out of bounds (meaning: an unknown character),
                    // fetch question mark in T using corresponding coordinates.
                    result+= row.Substring(L * (Z - A + 1), L);
                else
                    // If c is a known character, fetch corresponding ASCII representation
                    // in T by calculating its coordinates.
                    result+= row.Substring(L * (c - A), L);
            }
            Console.WriteLine(Z);
        }
    }
}

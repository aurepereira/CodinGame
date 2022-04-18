// https://www.codingame.com/ide/puzzle/mime-type

// STATEMENT
// Back to basics with this puzzle where you have to associate file names with their MIME type.

// SOLUTION
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        List<string> fileName = new List<string>(); // List holding file names

        // Create and fill dictionary containing types and descriptions
        Dictionary<string, string> inputs = new Dictionary<string, string>();
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string EXT = input[0].ToLower(); // file extension
            string MT = input[1]; // MIME type.
            inputs.Add(EXT, MT);
        }

        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine().ToLower(); // One file name per line.
            // Store characters from the last index of "." to the end of the string
            if (FNAME.Contains(".")) 
            {
                FNAME = FNAME.Substring(FNAME.LastIndexOf(".") + 1);
            }
            else 
            {
                FNAME = "UNKNOWN"; // If no "." found, store "UNKNOWN"
            }
            fileName.Add(FNAME);
        }

        foreach (string ext in fileName)
        {
            // If the line contains no filetype, print "UNKNOWN"
            if (!inputs.ContainsKey(ext))
            {
                Console.WriteLine("UNKNOWN");
            }
            else
            {
                // Else, print the value associated to the key {ext}
                string result = string.Empty;
                inputs.TryGetValue(ext, out result);
                Console.WriteLine(result);
            }
        }
    }
}

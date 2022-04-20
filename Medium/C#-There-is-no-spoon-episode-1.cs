// https://www.codingame.com/training/medium/there-is-no-spoon-episode-1

// STATEMENT
// The goal is to find, when they exist, the horizontal and vertical neighbors nodes from a two dimensional array. 
// The difficulty is in the number of nested loops that this puzzle can make you write. Do not get lost!

// SOLUTION
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis

        // Create a table of dimensions {width} by {height}
        var table = new char[width, height];

        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine(); // width characters, each either 0 or .

            // Insert power nodes into table
            for (int j = 0; j < width; j++) 
            {
                table[j, i] = line[j];
            }
        }

        // Analyze table values
        for (int i = 0; i < height; i++) 
        {
            for (int j = 0; j < width; j++) 
            {
                // Check current spot
                if (table[j, i] != '.')
                {
                    int nextX = j; // Current node X axis coordinate

                    // While current spot is not a node
                    while (++nextX < width && table[nextX, i] == '.');
                    // If next spot is a node, store its coordinates. If not, store "-1 -1"
                    string nextNodeX = nextX < width && (table[nextX, i] != '.') ? $"{nextX} {i}" : "-1 -1";

                    int nextY = i; // Current node Y axis coordinate
                    while (++nextY < height && table[j, nextY] == '.');
                    string nextNodeY = nextY < height && (table[j, nextY] != '.') ? $"{j} {nextY}" : "-1 -1";
            
                    Console.WriteLine($"{j} {i} {nextNodeX} {nextNodeY}");
                }
            }
        }
    }
}
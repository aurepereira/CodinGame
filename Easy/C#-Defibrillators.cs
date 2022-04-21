// https://www.codingame.com/training/easy/defibrillators

// STATEMENT
// The goal of this exercise is to make you find the closest point to given geographic coordinates (latitude and longitude). 
// Your program must print the associated location name. In this puzzle you will play a lot with conversion (degree to radian,
// coordinates to distance, string to float).

// SOLUTION
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    // Convert to radians
    static double Rad(string angle) 
    {
        return (Math.PI * Double.Parse(angle)) / 180;
    }

    static void Main(string[] args)
    {
        string LON = Console.ReadLine().Replace(',', '.'); // User's longitude
        string LAT = Console.ReadLine().Replace(',', '.'); // User's latitude
        int N = int.Parse(Console.ReadLine()); // Number of defibrillators in the streets
        string[] defibCollection = new string[] {}; // Table holding defibrillator information
        double closest = -1; // Variable storing the shortest distance
        string result = null; // String storing the defibrillator's name
        
        for (int i = 0; i < N; i++)
        {
            // Read input and replace commas with dots for calculation purposes
            string DEFIB = Console.ReadLine().Replace(',', '.');
            defibCollection = DEFIB.Split(';');

            // Compute x coordinate
            double x = (Rad(defibCollection[4]) - Rad(LON)) * Math.Cos((Rad(LAT) + Rad(defibCollection[5])) / 2);
            // Compute y coordinate
            double y = (Rad(defibCollection[5]) - Rad(LAT));
            // Compute distance between A and B
            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) * 6371;

            // If {closest} equals -1 (null equivalent), or if the new value of {d} is smaller than the value
            // currently stored in {closest}, store new value 
            if (closest == -1 || d < closest)
            {
                closest = d;
                result = defibCollection[1]; // Store defibrillator name for printing
            }
        }
        Console.WriteLine(result); // Print result
    }
}

//  https://www.codingame.com/training/easy/power-of-thor-episode-1

// STATEMENT
// A basic problem to go a little bit further with conditions and variables: 
// your program must allow Thor to reach the coordinates of the light of power in a 2D field.

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
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position
        int currentTx = initialTx; // Thor's current position
        int currentTy = initialTy; // Thor's current position

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
            string output = ""; // Variable holding the direction. Reinitialize the variable at the beginning of each turn.

            // Check direction along the Y axis.
            if (lightY > currentTy) {
                output = "S";
                currentTy++;
            } else if (lightY < currentTy) {
                output = "N";
                currentTy--;
            }

            // Check direction along the X axis.
            if (lightX > currentTx) {
                output = output + "E";
                currentTx++;
            } else if (lightX < currentTx) {
                output = output + "W";
                currentTx--;
            }

            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(output);
        }
    }
}

// https://www.codingame.com/training/easy/power-of-thor-episode-1

// STATEMENT
// A basic problem to go a little bit further with conditions and variables: 
// your program must allow Thor to reach the coordinates of the light of power in a 2D field.

// SOLUTION
var inputs = readline().split(' ');
const lightX = parseInt(inputs[0]); // the X position of the light of power
const lightY = parseInt(inputs[1]); // the Y position of the light of power
const initialTx = parseInt(inputs[2]); // Thor's starting X position
const initialTy = parseInt(inputs[3]); // Thor's starting Y position
let currentTx = initialTx; // Thor's current position
let currentTy = initialTy; // Thor's current position

// game loop
while (true) {
    const remainingTurns = parseInt(readline()); // The remaining amount of turns Thor can move. Do not remove this line.
    let output = ''; // Variable holding the direction. Reinitialize the variable at the beginning of each turn.

    // Check direction along the Y axis.
    if (lightY > currentTy) {
        output = 'S';
        currentTy++;
    } else if (lightY < currentTy) {
        output = 'N';
        currentTy--;
    }
    
    // Check direction along the X axis.
    if (lightX > currentTx) {
        output = output + 'E';
        currentTx++;
    } else if (lightX < currentTx) {
        output = output + 'W';
        currentTx--;
    }

    // A single line providing the move to be made: N NE E SE S SW W or NW
    console.log(output);
}
// https://www.codingame.com/training/easy/the-descent

// STATEMENT
// A simple problem to try out the CodinGame platform: your program must find the highest mountain out of a list of mountains.

// SOLUTION
/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/

// game loop
while (true) {
    const mountains = [];
    
    for (let i = 0; i < 8; i++) {
        const mountainH = parseInt(readline()); // represents the height of one mountain.
        mountains.push(mountainH);
    }
    const target = mountains.indexOf(mountains.reduce((a,b)=>Math.max(a,b), -Infinity));
    console.log(target);     // The index of the mountain to fire on.
}
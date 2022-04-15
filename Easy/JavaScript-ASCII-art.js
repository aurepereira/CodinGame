// https://www.codingame.com/training/easy/ascii-art

// STATEMENT
// The goal of the problem is to simulate an old airport terminal display: your program must display a line of text in ASCII art.
// You have to split strings, store them and recreate others. You can use data structures like arrays or hash tables.

// SOLUTION
const L = parseInt(readline());
const H = parseInt(readline());
const T = readline();

// Define lower and upper bounds
const a = 'A', z = 'Z';
const aI = a.charCodeAt(0);
const zI = z.charCodeAt(0);

// Convert text input to uppercase
let str = T.toUpperCase();

// Convert input to ASCII
for (let i = 0; i < H; i++) {
    const ROW = readline();
    var result = '';

    for (var j = 0; j < str.length; j++) {
        var s = str.charAt(j);

        // Convert string representation to integer
        var c = s.charCodeAt(0);
        
        if (c < aI || c > zI) {
            // If c is out of bounds (meaning: an unknown character),
            // fetch question mark in T using corresponding coordinates.
            result += ROW.substr(L * (zI - aI + 1), L);
        } else {
            // If c is a known character, fetch corresponding ASCII representation
            // in T by calculating its coordinates.
            result += ROW.substr(L * (c - aI), L);
        }
    }

    console.log(result);
}
// https://www.codingame.com/training/easy/unary

// STATEMENT
// Your program must encode a string into a series of zeros.
// A string is an encoded form of digital values and you have to transform those values into a new format.

// SOLUTION
const MESSAGE = readline();
let binaryT = ''; // Variable holding binary conversion

// Convert MESSAGE to binary
for (let i = 0; i < MESSAGE.length; i++) {
    binaryT += MESSAGE.charCodeAt(i).toString(2).padStart(7, '0');
}

// Convert binary to unary
const regex = /(1*)(0*)/g;

const unaryT = binaryT.replace(regex, (str, g1, g2) => {
    let a = '';
    let b = '';

    if (g1)a = '0 ' + '0'.repeat(g1.length);
    if (g2)b = '00 ' + '0'.repeat(g2.length);

    if (a && b) {
    return a + ' ' + b + ' ';
    } else if (a) {
        return a + ' ';
    } else if (b) {
        return b + ' ';
    } else {
        return '';
    }
});

// Print result
console.log(unaryT.trim());
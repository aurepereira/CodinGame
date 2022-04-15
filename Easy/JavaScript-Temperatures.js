// https://www.codingame.com/training/easy/temperatures

// STATEMENT
// Your program must analyze records of temperatures to find the closest to zero.

// SOLUTION
const n = parseInt(readline()); // the number of temperatures to analyse
var inputs = readline().split(' ');

let temp = 0;

for (let i = 0; i < n; i++) {
    if (temp === 0) {
        temp = inputs[i];
    } else if (inputs[i] > 0 && inputs[i] <= Math.abs(temp)) {
        temp = inputs[i];
    } else if (inputs[i] < 0 && - inputs[i] < Math.abs(temp)) {
        temp = inputs[i];
    }
}

console.log(temp);
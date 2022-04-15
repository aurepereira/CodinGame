// https://www.codingame.com/training/easy/horse-racing-duals

// STATEMENT
// In this problem you have to find the two numbers that are closest to each other among a list of numbers. 
// The list might be really large and force you to search for the best possible algorithmic complexity for your solution.

// SOLUTION
// Declare an empty array to hold horse strengths, and a variable
// 'diff' that holds the smallest difference found.
let pi = [];
let diff = null;
const N = parseInt(readline());
 
// Insert horse strength values into the array.
for (let i = 0; i < N; i++) {
    pi[i] = parseInt(readline());
}

// Sort array in ascending order.
pi.sort((a,b) => a-b);
 
// Perform calculations to find the smallest difference.
// Substract the next adjacent value to the current value.
for (let i = 0; i < pi.length - 1; i++) {
    const newDiff = pi[i + 1] - pi[i];
    diff = diff === null ? newDiff : Math.min(diff, newDiff);
}
 
// Display the result.
console.log(diff);
// https://www.codingame.com/ide/puzzle/mime-type

// STATEMENT
// STATEMENT
// Back to basics with this puzzle where you have to associate file names with their MIME type.

// SOLUTION
const N = parseInt(readline()); // Number of elements which make up the association table.
const Q = parseInt(readline()); // Number Q of file names to be analyzed.

// Create and fill table containing types and descriptions
const typeList = type => {
    const inputs = readline().split(' ');
    type[inputs[0].toLowerCase()] = inputs[1];
    return type;
}

// Create an empty array of length N and populate it with typeList
const extensionList = [...Array(N)].reduce(typeList, {});

// Get file extension, and print result
console.log([...Array(Q)]
    .map( () => {
        const extension = readline().toLowerCase().split('.'); // Get file extension
        const i = (extension.length > 1) ? (extension.length - 1) : 1;
        // Search for MIME type in extension[] and return corresponding result
        return (extensionList[extension[i]] || 'UNKNOWN');
    })
    .join('\n') // Format output
);

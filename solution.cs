Here is a simple JavaScript console application that validates if a string is a valid number format:

```javascript
const readline = require('readline').createInterface({
  input: process.stdin,
  output: process.stdout
});

readline.question('Enter a string to validate: ', (input) => {
  console.log(isNumber(input) ? 'Valid number format' : 'Invalid number format');
  readline.close();
});

function isNumber(str) {
  return !isNaN(parseFloat(str)) && isFinite(str);
}
```

This application uses the built-in `readline` module in Node.js to read a line of input from the console. It then calls the `isNumber` function with the input string to check if it's a valid number format. The `isNumber` function uses the `isNaN` and `isFinite` functions to check if the string can be converted to a number and if it's a finite number, respectively.
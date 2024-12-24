readline.question('Enter a string to validate: ', (input) => {
  console.log(isNumber(input) ? 'Valid number format' : 'Invalid number format');
  readline.close();
});
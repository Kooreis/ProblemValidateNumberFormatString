Here is a simple TypeScript console application that validates if a string is a valid number format:

```typescript
class NumberValidator {
    static isValidNumber(input: string): boolean {
        return !isNaN(Number(input));
    }
}

// Test the NumberValidator
console.log(NumberValidator.isValidNumber("123")); // true
console.log(NumberValidator.isValidNumber("123.456")); // true
console.log(NumberValidator.isValidNumber("1.23e4")); // true
console.log(NumberValidator.isValidNumber("abc")); // false
console.log(NumberValidator.isValidNumber("12a3")); // false
console.log(NumberValidator.isValidNumber(" ")); // false
```

This application defines a `NumberValidator` class with a static method `isValidNumber`. This method uses the `isNaN` and `Number` functions to check if the input string can be converted to a number. If it can, the method returns `true`; otherwise, it returns `false`. The application then tests this method with various inputs.
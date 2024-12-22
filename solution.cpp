```cpp
#include <iostream>
#include <string>
#include <cctype>

bool isValidNumber(const std::string& str) {
    int decimalCount = 0;
    for (char const &c : str) {
        if (!std::isdigit(c) && c != '.') {
            return false;
        }
        if (c == '.') {
            decimalCount++;
            if (decimalCount > 1) {
                return false;
            }
        }
    }
    return true;
}

int main() {
    std::string str;
    std::cout << "Enter a string: ";
    std::cin >> str;
    if (isValidNumber(str)) {
        std::cout << "The string is a valid number format.\n";
    } else {
        std::cout << "The string is not a valid number format.\n";
    }
    return 0;
}
```
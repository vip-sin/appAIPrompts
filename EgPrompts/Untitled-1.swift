// Pseudocode for Calculator User Interface

// Define a class to represent the calculator UI
class CalculatorUI {
    // Define variables to hold user input and calculation result
    int num1, num2, result;

    // Function to get user input for two numbers
    function GetUserInput() {
        print "Enter the first number: "
        num1 = read input
        print "Enter the second number: "
        num2 = read input
    }

    // Function to perform addition
    function Add() {
        result = num1 + num2
        log "Addition: " + num1 + " + " + num2 + " = " + result
    }

    // Function to perform subtraction
    function Subtract() {
        result = num1 - num2
        log "Subtraction: " + num1 + " - " + num2 + " = " + result
    }

    // Function to perform multiplication
    function Multiply() {
        result = num1 * num2
        log "Multiplication: " + num1 + " * " + num2 + " = " + result
    }

    // Function to perform division
    function Divide() {
        // Handle division by zero error
        if (num2 == 0) {
            log "Error: Division by zero is not allowed"
            return
        }

        result = num1 / num2
        log "Division: " + num1 + " / " + num2 + " = " + result
    }

    // Function to run the calculator
    function RunCalculator() {
        GetUserInput()

        // Perform calculations based on user input
        Add()
        Subtract()
        Multiply()
        Divide()
    }
}

// Unit test cases
function RunTests() {
    // Create an instance of the CalculatorUI class
    CalculatorUI calculator = new CalculatorUI()

    // Test addition
    calculator.num1 = 10
    calculator.num2 = 5
    calculator.Add() // Expected output: Addition: 10 + 5 = 15

    // Test division by zero
    calculator.num1 = 7
    calculator.num2 = 0
    calculator.Divide() // Expected output: Error: Division by zero is not allowed
}

// Main program
function Main() {
    // Create an instance of the CalculatorUI class
    CalculatorUI calculator = new CalculatorUI()

    // Run the calculator
    calculator.RunCalculator()

    // Run the unit test cases
    RunTests()
}

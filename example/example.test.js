var calculator = function (num1, num2, operation) {
  var result = 0;
  switch (operation) {
    case "+":
      result = num1 + num2;
      break;
    case "-":
      result = num1 - num2;
      break;
    case "*":
      result = num1 * num2;
      break;
    case "/":
      result = num1 / num2;
      break;
  }
  console.log(result);
};
// write a unit test for the calculator function
var assert = require("assert");

assert.equal(calculator(1, 2, "+"), 3, "Calculator should return 3");
assert.equal(calculator(1, 2, "-"), 1, "Calculator should return 1");
assert.equal(calculator(1, 2, "*"), 2, "Calculator should return 2");
assert.equal(calculator(1, 2, "/"), 1, "Calculator should return 1");

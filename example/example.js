// regex to find the first word in a string

var wordRegex = /\b[a-zA-Z]+\b/g;

// regex to match phone numbers of in format (xxx) xxx-xxxx

var phoneRegex = /\(\d{3}\) \d{3}-\d{4}/g;
// test phoneRegex against any phone number with console.log

var phone = "123-456-7890";
console.log(phoneRegex.test(phone));

/// create a function to exchange two strings

function exchange(str1, str2) {
  return str1 + str2;
}

// call the function

console.log(exchange("hello", "world"));

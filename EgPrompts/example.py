# funtion determine even number 
def is_even(num):
    if num % 2 == 0:
        return True
    else:
        return False
# funtion to test if number is prime
def is_prime(num):
    for i in range(2, num):
        if num % i == 0:
            return False
    return True
# funtion to test if number is palindrome
def is_palindrome(num):
    num = str(num)
    if num == num[::-1]:
        return True
    else:
        return False
#  test above functions with test cases
print(is_even(10))
print(is_even(15))
print(is_even(25))
print(is_even(35))
print(is_even(45))
print(is_even(55))

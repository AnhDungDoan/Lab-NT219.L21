import random

def miller_rabin(n, k):

    if n == 2 or n == 3:
        return True

    if n % 2 == 0:
        return False

    # (r = 0, s = n - 1)
    # s = 2^r * m
    r, s = 0, n - 1
    while s % 2 == 0:
        r += 1
        s //= 2
    
    for _ in range(k):
        a = random.randrange(2, n - 1)
        x = pow(a, s, n)
        if x == 1 or x == n - 1: #with 1 or -1
            continue
        for _ in range(r - 1):
            x = pow(x, 2, n)
            if x == n - 1: # with -1
                break
        else:
            return False
    return True

def genprimeBits(k):
    x = ""
    k = int(k)
    for y in range(k):
        x = x + "1"
    y = "1"
    for z in range(k-1):
        y = y + "0"
    x = int(x,2)
    y = int(y,2)
    p = 0

    while True:
        p = random.randrange(y,x)
        if miller_rabin(p,100):
            break
    return p

def GCD(a, b):
    if (a < b):
        a, b = b, a

    tmp = a % b
    while (b != 0):
        t = a % b
        a = b
        b = t
        
    return a

def powmod(a, x, p):
    ans = 1
    for i in range(1, x + 1):
        ans = ((ans * a % p) + p*p) %p
    return ans

print(
"""
    TASK 3.1
    1. Prime number:
        + Generate a random prime numbers with 2 bytes, 8 bytes, 32 bytes long
        + Determine 10 largest prime number under 10 first Mersenne prime numbers.
        + Check if an arbitrary integer less than 2^89 - 1 is prime or not
    2. Determine the greatest common divisor (gcd) of 2 arbitrary “large” integers (which are as large as possible that you can handle)
    3. Compute the modular exponentiation a^x mod p. Your program should be able to compute in case of “large” exponents (x>40), for example 7^40 mod 19

    Choose which case: 
"""
)

option = int(input())

if option == 1:
    print(genprimeBits(int(input("1.1: How many byte of prime? "))) * 8)
    print()
    #######
    print("1.2: 10 largest prime number under 10 first Mersenne prime numbers are: ")
    cnt = 0
    for i in range(2, 100):
        pre_prime = pow(2, i) - 1
        if (miller_rabin(pre_prime, 100) == True):
            cnt += 1
            print(cnt, ": ", pre_prime)
            if (cnt == 10):
                break
    print()
    ############
    if (miller_rabin(pow(2, 89) - 1, 100) == True):
        print("1.3: 2^89 - 1 is a prime")
    else:
        print("1.3: 2^89 - 1 is not a prime")
    print()
elif option == 2:
    a, b = [int(x) for x in input("Write 2 numbers to calculate: ").split()]
    print("2: GCD({}, {}) is: {}".format(a, b, GCD(a,b)))
elif option == 3:
    a, x, p = [int(x) for x in input("Write a, x, p to calculate: a^x %p: ").split()]
    print("3: {}^{} % {} = ".format(a, x, p), powmod(a, x, p))






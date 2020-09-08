import math

def maxPrimeFactors(n):
    if n<=0:
        return 0
    maxPrime = -1

    while n%2==0:
        maxPrime = 2
        n/=2
    
    for i in range(3,int(math.sqrt(n)),2):
        while n%i==0:
            maxPrime = i
            n = n/i

    if n>2:
        maxPrime = n
    return int(maxPrime)


n = int(input())
count = 0
while(n!=0):
    m=maxPrimeFactors(n)
    if(m!=n):
        count+=1
        n=m
    else:
        n -=1
print(count+1)
    


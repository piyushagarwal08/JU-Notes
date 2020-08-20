TestCase = int(input())

def Solution(zero,one,two):
    if zero == 0 and one != 0 and two != 0:
        print("No")
    elif zero==0 and one==0 and two!= 0:
        print("Yes")
    elif zero==0 and one != 0 and twp==0:
        print("Yes")
    elif zero <= (one+two+1):
        print("Yes")
    else:
        print("No")
    
while(TestCase!=0):
    size = int(input())
    list1 = list(map(int,input().split()))

    input_array = []
    for data in range(size):
        input_array.append(list1[data]%3)

    no_of_zeros = input_array.count(0)
    no_of_ones = input_array.count(1)
    no_of_twos = input_array.count(2)

    Solution(no_of_zeros,no_of_ones,no_of_twos)
    TestCase -= 1

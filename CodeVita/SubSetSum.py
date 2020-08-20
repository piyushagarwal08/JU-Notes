def SubSetSum(list2,n,sum1):
    list1 = []
    for i in range(len(list2)+1):
        list1.append([0]*(sum1+1))
    
    for i in range(n+1):
        list1[i][0] = 1
    
    for i in range(1,n+1):
        for j in range(1,(sum1+1)):
            if(list2[i-1] > j):
                list1[i][j] = list1[i-1][j]
            else:
                list1[i][j] = list1[i-1][j] or list1[i-1][j-list2[i-1]]

    return list1[n][sum1]


list1 = [2,2,3]
sum1 = 5
print(SubSetSum(list1,3,sum1))

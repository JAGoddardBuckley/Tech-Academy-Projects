def sort(alist): #define sorting method
    for i in range(1, len(alist)): #set range to ascending order from 1
                                        #until the length of a list - i is index

        v = alist[i]  #value variable 
        p = i         #place variable 

        while p > 0 and alist[p-1] > v: #run comparison through nested
                                                    #while loop
            alist[p]=alist[p-1]
            p = p-1

        alist[p]=v

#alist = [67, 45, 2, 13, 1, 998] -- first list to sort
alist = [89, 23, 33, 45, 10, 12, 45, 45, 45] #second list to sort
sort(alist) #call method
print (alist) #print result
        

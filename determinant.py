import random

def det(x):
    if len(x) == 1:
        return x[0][0]
    
    d = 0
    s = 1
    for i in range(len(x)):
        new = rowAndIdelete(x, i)
        d += s * x[0][i] * det(new)
        s = -s
    return d

def rowAndIdelete(x, index):
    new = []
    for i in range(1, len(x)):
        a = []
        for j in range(len(x[0])):
            if j != index:
                a.append(x[i][j])
        new.append(a)
    return new


l = 3

arr = [[random.randint(0, 9) for e in range(3)] for e in range(3)]

print(arr)
print(det(arr))

#1
def a():
    return 5
print(a())
#prints the number 5


#2
def a():
    return 5
print(a()+a())
#prints the number 10


#3
def a():
    return 5
    return 10
print(a())
#prints the number 5


#4
def a():
    return 5
    print(10)
print(a())
#prints the number 5


#5
def a():
    print(5)
x = a()
print(x)
#prints 5, x is undefined


# #6
# def a(b,c):
#     print(b+c)
# print(a(1,2) + a(2,3))
# #prints 3 and 5, then prints none (correct output: prints 3 and 5 then gives error, '+' operator not defined for NoneType)


#7
def a(b,c):
    return str(b)+str(c)
print(a(2,5))
#prints string 25


#8
def a():
    b = 100
    print(b)
    if b < 10:
        return 5
    else:
        return 10
    return 7
print(a())
#prints 100 and 10


#9
def a(b,c):
    if b<c:
        return 7
    else:
        return 14
    return 3
print(a(2,3))
print(a(5,3))
print(a(2,3) + a(5,3))
#prints 7, prints 14, prints 21


#10
def a(b,c):
    return b+c
    return 10
print(a(3,5))
#prints 8


#11
b = 500
print(b)
def a():
    b = 300
    print(b)
print(b)
a()
print(b)
#prints 500, prints 500, prints 300, prints 500


#12
b = 500
print(b)
def a():
    b = 300
    print(b)
    return b
print(b)
a()
print(b)
#prints 500, prints 500, prints 300, prints 500


#13
b = 500
print(b)
def a():
    b = 300
    print(b)
    return b
print(b)
b=a()
print(b)
#prints 500, prints 500, prints 300, prints 300


#14
def a():
    print(1)
    b()
def b():
    print(3)
a()
#prints 1, 3, 2


#15
def a():
    print(1)
    x = b()
    print(x)
    return 10
def b():
    print(3)
    return 5
y = a()
print(y)
#prints 1, prints 3, prints 5, prints 10
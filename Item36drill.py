#set variable x to the integer 5
x = 5

#set variable y to the string "yellow"
y = "yellow"

#set flt to the decimal value 1.25
flt = float(1.25)

#print float variable formatted for at least 4 characters with 3 after the decimal
print '{:4.3f}'.format(flt)

#set variable a to the integer 10
a = 10

#use the + operator
print(x+a)

#use the - operator
print(a-x)

#use the * operator
print(a*x)

#use the / operator
print(a/x)

# use += to increment
count = 0
#while count is < 4 run a loop
while count < 4:
    print count #show count value
    count +=1 #increment by 1

#use the = operator which assigns a value to a variable
numArray = [2,4,6,8]

#use the % operator
b = 7
c = 2
print(b%c)

#use and logical operator
if x and y == 2:
    print 'There is a green cow.'
#use or logical operator
if x or y == "yellow":
    print 'Yellow is pretty.'
#use not logical operator
if not b == 7:
    print '7 is not 7'

#use if, elif, and else statements
if b == 2:
   print " I love bunnies."
elif b < 2:
    print " I love bananas."
else:
    print "I love chocolate."

#use of a while loop
count = 0
while count < 3: #while statement condition
 print "Hip, hip, hooray!" #instuction
 count += 1 #increment count

#use of a for loop in the range of 0 - 3
for count in range(0,3):
    print "Three cheers for Captain Spalding!"

#create a list of colors
colorList = ["red", "orange", "yellow",
                 "green", "blue", "purple",]
#loop through colorList items     
for color in colorList:
    print color.title() + " is a beautiful color! "

#create a tuple of animals
animals = ("dogs", "cats", "birds",)
#loop through animals items
for animal in animals:
    print "I love " + animal

#define function returning a string variable
def myString(x,y):
    divide = float(x)/float(y)
    return str(divide) #return divide as a string variable

#call myString function
print myString(10,2)
    
    
    

    

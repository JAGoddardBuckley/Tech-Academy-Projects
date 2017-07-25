
import datetime
from datetime import * 
import pytz
from pytz import timezone
import time


now_time = datetime.now(timezone('UTC'))

London = now_time.astimezone(timezone('Europe/London'))
LDN = London.strftime('%H : %M : %S')
#print London
NewYork = now_time.astimezone(timezone('US/Eastern'))
NY = NewYork.strftime('%H : %M : %S')
#print NewYork  

def NewYorkOpen():
    if NewYork.hour >=9 and NewYork.hour <=21:
        print "New York is open!"
    else:
        print "New York is closed."
    

def LondonOpen():
   if London.hour >=9 and London.hour <=21:
        print "London is open!"
   else:
       print "London is closed."

LondonOpen()
NewYorkOpen()




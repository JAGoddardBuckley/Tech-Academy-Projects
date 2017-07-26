import shutil
import os
from datetime import *
import time

NewFiles = "/Users/Student/Desktop/Folder_A"
Destination = "/Users/Student/Desktop/Folder_B"

beforeToday = datetime.now() - timedelta(days=1)

def nowTime(NewFiles):
    t = os.path.getmtime(NewFiles)
    return datetime.fromtimestamp(t)
    
def sendFiles():
    for i in os.listdir(NewFiles):
        time = nowTime(NewFiles + '/' + i)
        if beforeToday < time:
            
            shutil.move(NewFiles +'/' + i, Destination)
        
            
        
    
            

nowTime(NewFiles)
sendFiles()


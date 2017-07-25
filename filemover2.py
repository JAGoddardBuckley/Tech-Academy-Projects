import shutil
import os


movingFiles = "/Users/Student/Desktop/Folder_A"
Destination = "/Users/Student/Desktop/Folder_B"

def filemove():
    for i in os.listdir(movingFiles):
        shutil.move(movingFiles +'/'+ i, Destination)

def FolderFinal():       
    for i in os.listdir(Destination):
        print os.path.dirname(Destination) + '/' + i

filemove()
FolderFinal()

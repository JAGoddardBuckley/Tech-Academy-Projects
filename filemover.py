import shutil

 
movingFiles = ('/Users/Student/Desktop/Folder_A/txt1.txt','/Users/Student/Desktop/Folder_A/txt2.txt',
'/Users/Student/Desktop/Folder_A/txt3.txt','/Users/Student/Desktop/Folder_A/txt4.txt')
              
Destination = "/Users/Student/Desktop/Folder_B"


def filemove():
    shutil.move(movingFiles[0], Destination)
    print Destination + '/txt1.txt'
    shutil.move(movingFiles[1], Destination)
    print Destination + '/txt2.txt'
    shutil.move(movingFiles[2], Destination)
    print Destination + '/txt3.txt'
    shutil.move(movingFiles[3], Destination)
    print Destination + '/txt4.txt'


filemove()

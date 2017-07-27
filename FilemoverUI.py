from tkinter import *
from tkinter import messagebox
from tkinter import filedialog
from tkinter import ttk
import shutil
import os
from datetime import *
import datetime as dt
import time

root =Tk()

####################GUI#################

def load_gui():
    source_fldr = ttk.Button(text = "Source Folder", command = askSource()).grid(row =0,
                            column =2, padx = 10, pady =10)
    pathLabel = ttk.Entry(text = sentF).grid(row =0, column=1, padx =10, pady =10)

    destination_fldr = ttk.Button(text = "Destination Folder", command = askDestination()).grid(row = 1,
                                column = 2, padx = 10, pady = 10)
    pathLabel = ttk.Entry(text = destF).grid(row = 1, column = 1, padx = 10, pady=10)

    checkFile = ttk.Button(text = "Send Files", command = fileCopy()).grid(row = 2,
                           column = 1, columnspan = 2, padx = 10, pady = 10)

   

   




##############functions###############


sentF = StringVar()
destF = StringVar()

def askSource():
    desName = filedialog.askdirectory()
    sentF.set(desName)

def askDestination():
    desName = filedialog.askdirectory()
    destF.set(desName)

def fileCopy():
    now = dt.datetime.now()

 #get the paths for send and receive folders
    sending = sentF.get()
    receiving = destF.get()
    beforeToday = now - dt.timedelta(hours = 24)
    for newFiles in os.listdir(sending):
        path = os.path.join(sending, newFiles)
        st = os.stat(path)
        mtime = dt.datetime.fromtimestamp(st.st_mtime)
        if mtime > beforeToday:
            shutil.copy2(path, receiving)
            print (newFiles)


            
def ask_quit():
    if messagebox.askokcancel("Exit program", "Okay to exit application?"):
        self.master.destroy()
        os._exit(0)


    

load_gui()
root.mainloop()

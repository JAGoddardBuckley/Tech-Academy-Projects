#Phone Book demo Drill The Tech Academy using Tkinter 
#Jenn Buckley
#Python Ver: 3.6.2


from tkinter import *
import tkinter as tk


#import other modules
import phonebook_gui
import phonebook_func

#Frame is the Tkinter frame class our class inherits
class ParentWindow(Frame):
    def __init__(self, master, *args, **kwargs):
        Frame.__init__(self, master, *args, **kwargs)

        #define master frame config
        self.master = master
        self.master.minsize(500,300) # height, width
        self.master.maxsize(500,300)
        #CenterWindow method cetners app on user's screen
        phonebook_func.center_window(self,500,300)
        self.master.title('The Tkinter Phonebook Demo')
        self.master.configure(bg='#F0F0F0')
        #protocol method built-in to tkinter for when user clicks
        #upper corner X
        self.master.protocol('WM_DELETE_WINDOW', lambda: phonebook_func.ask_quit(self))
        arg = self.master

        #load GUI widgets from other module
        #for clutter free code
        phonebook_gui.load_gui(self)





if __name__ == '__main__':
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()









# -*- coding: utf-8 -*-
import tkinter as tk                # python 3
from tkinter import font  as tkfont
from PIL import ImageTk,Image
from tkinter import filedialog 
# python 3
#import Tkinter as tk     # python 2
#import tkFont as tkfont  # python 2




class SampleApp(tk.Tk):

    def __init__(self, *args, **kwargs):
        tk.Tk.__init__(self, *args, **kwargs)

        self.title_font = tkfont.Font(family='Helvetica', size=18, weight="bold", slant="italic")

        # the container is where we'll stack a bunch of frames
        # on top of each other, then the one we want visible
        # will be raised above the others
        container = tk.Frame(self)
        container.pack(side="top", fill="both", expand=True)
        container.grid_rowconfigure(0, weight=1)
        container.grid_columnconfigure(0, weight=1)
         
        self.frames = {}
        

        for F in (StartPage, PageOne, PageTwo):
            page_name = F.__name__
            frame = F(parent=container, controller=self)
            self.frames[page_name] = frame

            # put all of the pages in the same location;
            # the one on the top of the stacking order
            # will be the one that is visible.
            frame.grid(row=0, column=0, sticky="nsew")

        self.show_frame("StartPage")
        

    def show_frame(self, page_name):
        '''Show a frame for the given page name'''
        frame = self.frames[page_name]
        frame.tkraise()
        



class StartPage(tk.Frame):

    def __init__(self, parent, controller):
        tk.Frame.__init__(self, parent,relief='raised',borderwidth=3)
        self.controller = controller
        
        #backgrpund Image
        load = Image.open(r"C:\Users\Osama\Desktop\Final Year Project\UI Background.jpeg")
        render = ImageTk.PhotoImage(load)
        img = tk.Label(self, image=render)
        img.image = render
        img.place(x=0, y=0)
        
        label = tk.Label(self, text="Welcome To Spinal Scanner",bg='light blue', font=controller.title_font)
        label.pack(side="top", pady=10)

        button1 = tk.Button(self, text="Go",width=20, height=2,
                            command=lambda: controller.show_frame("PageOne")).place(x=450,y=450)
        

class PageOne(tk.Frame):

    def __init__(self, parent, controller):
        tk.Frame.__init__(self, parent,relief='raised',borderwidth=3)
        self.controller = controller
        
        #backgrpund Image
        load = Image.open(r"C:\Users\Osama\Desktop\Final Year Project\UI Background.jpeg")
        render = ImageTk.PhotoImage(load)
        img = tk.Label(self, image=render)
        img.image = render
        img.place(x=0, y=0)
        
        
        
        bt_back = tk.Button(self, text="Back",width=15, height=2,
                           command=lambda: controller.show_frame("StartPage")).place(x=40,y=540)
                      
        preview = tk.Label(self,text='Image Preview',width=35, height=16,font='Helvetica 9 bold',bg='grey',borderwidth=4, relief="solid")
        preview.place(x=380,y=170)
        
        #Image Open Button
        btn = tk.Button(self, text ='Open Image',width=20, height=2,command = self.open_img).place(x=420,y=25)
        bt_next = tk.Button(self, text="Next",width=15, height=2,
                           command=lambda: controller.show_frame("PageTwo")).place(x=840,y=540)
               
    def openfilename(self): 
  
    # open file dialog box to select image 
    # The dialogue box has a title "Open" 
        filename = filedialog.askopenfilename(title ='open')
        return filename
        
        
    def open_img(self): 
        # Select the Imagename  from a folder  
        x = self.openfilename() 

        # opens the image 
        img = Image.open(x) 

        # resize the image and apply a high-quality down sampling filter 
        img = img.resize((250, 250), Image.ANTIALIAS) 

        # PhotoImage class is used to add image to widgets, icons etc 
        img = ImageTk.PhotoImage(img) 

        # create a label 
        panel = tk.Label(self,borderwidth=4, relief="solid",image = img).place(x=380,y=170)

        # set the image as img  
        panel.image = img 
        panel.grid(row = 2)
        
        
        
                                        

class PageTwo(tk.Frame):

    def __init__(self, parent, controller):
        tk.Frame.__init__(self, parent, relief='raised',borderwidth=3)
        self.controller = controller
        
        #backgrpund Image
        load = Image.open(r"C:\Users\Osama\Desktop\Final Year Project\UI Background.jpeg")
        render = ImageTk.PhotoImage(load)
        img = tk.Label(self, image=render)
        img.image = render
        img.place(x=0, y=0)


        bt_back = tk.Button(self, text="Back",width=15, height=2,
                           command=lambda: controller.show_frame("PageOne")).place(x=40,y=540)
        
    


if __name__ == "__main__":
    app = SampleApp()
    app.resizable(0,0)
    app.geometry('1000x610')
    app.title('Spinal Scanner')
    app.mainloop()

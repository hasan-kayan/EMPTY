# DiscordBotUBN

# In this code you can find basic structure of a Discord Bot that works with Discord API 
# main.py file include three modules, two of them is own writed and the third one is Python's Discord module which has specific functions to use and manage bot. 


In my own modules, you can see QRCode.py and questionGenerator modules.

######################## QRCode.py ###################################

urlToQR : Takes a url when it works and generates a QR code which keeps the URL 

      USAGE  : In main file, we first call module and then we call the function in to it. 
      
     -    QRCode.urlToQR(url)

  

textToQR: This function just takes a string and generates the QR code. 

    USAGE : Same logic as other functions. 
     
     - QRCode.textToQR()



####################### questionGenerator.py ##########################

In this module, we have random library and a .txt file which we have random algorithm questions. This module just have one function, sends random questions. 

get_random_question() : This function open a .txt file and reads it line by line, takes one random line and returns it to user. 

      USAGE : Almost all Python modules have same usage logic we should first call the module. 
      
      - questionGenerator.get_random_question() 













NOTE
async functions has very different architecture so if you want to learn about Asynchronous Programming you can ask...


# Import QRCode from pyqrcode
import pyqrcode
import png
from pyqrcode import QRCode

def urlToQR(): 
     # String which represents the QR code
        # Take an input of the URL to import it in QR 
        embeddedURL = input("Please enter the url you want to embedded : ")
        
        # Generate QR code
        url = pyqrcode.create(embeddedURL)
        
        # Create and save the svg file naming "myqr.svg"
        url.svg("myqr.svg", scale = 8)
        
        # Create and save the png file naming "myqr.png"
        url.png('myqr.png', scale = 6)

def textToQR():
    text = input("Please enter the text you want to embedded : ") 
    # Generate QR code
    write = pyqrcode.create(text)
    # Create and save the svg file naming "myqr.svg"
    write.svg("myqr.svg", scale = 8)

    # Create and save the png file naming "myqr.png"
    write.png('myqr.png', scale = 6)

urlToQR()
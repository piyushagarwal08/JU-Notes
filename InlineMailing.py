# Send an HTML email with an embedded image and a plain text message for
# email clients that don't want to display the HTML.
import smtplib
from email.mime.multipart import MIMEMultipart
from email.mime.text import MIMEText
from email.mime.image import MIMEImage

def SendMail(From,Password,To,Message,Subject,ImgPath):
    # Define these once; use them twice!
    strFrom = From
    strTo = To

    # Create the root message and fill in the from, to, and subject headers
    msgRoot = MIMEMultipart('related')
    msgRoot['Subject'] = Subject
    msgRoot['From'] = strFrom
    msgRoot['To'] = strTo
    msgRoot.preamble = 'This is a multi-part message in MIME format.'

    # Encapsulate the plain and HTML versions of the message body in an
    # 'alternative' part, so message agents can decide which they want to display.
    msgAlternative = MIMEMultipart('alternative')
    msgRoot.attach(msgAlternative)
    
    msgText = MIMEText('This is the alternative plain text message.')
    msgAlternative.attach(msgText)
    
    # We reference the image in the IMG SRC attribute by the ID we give it below
    # '<b>Some <i>HTML</i> text</b> and an image.<br><img src="cid:image1" width=20px height=30px><br>Nifty!'
    msgText = MIMEText(Message, 'html')
    msgAlternative.attach(msgText)

    # This example assumes the image is in the current directory
    fp = open(ImgPath, 'rb')
    msgImage = MIMEImage(fp.read())
    fp.close()

    # Define the image's ID as referenced above
    msgImage.add_header('Content-ID', '<image1>')
    msgRoot.attach(msgImage)

    # Send the email (this example assumes SMTP authentication is required)
    
    smtp = smtplib.SMTP('smtp.gmail.com',587)
    smtp.starttls()
    smtp.login(strFrom,Password)
    smtp.sendmail(strFrom,strTo,msgRoot.as_string())
    smtp.quit()
    return "hey"


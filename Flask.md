# Flask
<a href="flask.palletsprojects.com">Flask Documentation </a>

# Virtual Environment

## Note
* To Open ```Terminal``` in ```VS Code``` use ```Ctrl (back-quote)```
* One might face issue activating virtual environment through ```VS Code```, something like ```File ..\venv\Scripts\Activate.ps1 cannot be loaded because running scripts is disabled on this system. ```
* To Solve this scenario, follow the given steps:
    1. Open ```Powershell``` as ```Administrator```
    2. Run ```set-executionpolicy remotesigned```
    3. A Message ```pop-ups``` for permission, enter ```Y```
    4. Its done, now you can activate virtual environment

## Pipenv
* Its best to create virtual environments for different projects so that one can easily maintain the version for each module specific to each projects
* To install ```pipenv``` use ```py -m pip install pipenv```
* To create a virtual environment , ```py -m pipenv install``` inside the project directory, this gives us two files ```Pipfile``` and ```Pipfile.lock```
* To activate the environment, run ```pipenv shell```
* To exit from the environent, type ```exit```
* To install any module, once inside the ```environment```, run ```pipenv install module-name```

## Virtualenv (venv)
* Just like ```Pipenv```, we can also use the ```venv``` module of python to create a virtual environment
* To install ```venv```, run ```pip install virtualenv```
* To create virtual environment, ```py -m venv environment-name```
* To activate the environment, run ```environment-name/Scripts/Activate```
* To exit the environment, run ```deactivate```
* To install any module inside the environment, run ```pip install module-name```

# General Setup
* To run any ```Flask APP```
    1.  run ```set FLASK_APP=hello```
    2. run ```flask run```
<img src="Images\Flask_basic_run.png" />

* To run a development environment, where FLASK keeps on updating itself from code, run ```set FLASK_ENV=development```
* It makes the debugger mode ```on```
* The flask runs the ```app.py``` file by default, and if its present then no need to specify the ```FLASK_APP```
* Be default ```FLASK``` only allows ```GET``` request
* To allow other method, we need to define ```methods=["GET","POST"]```
* To pass data between ```developer code``` and ```user```, we need to define ```secret_key``` inside ```app.py```
```py
app = Flask(__name__)
app.secret_key = "jh34jh3j4h3jh43j4h9edj23u28khd389hdjsn"
# here this secret key can be anything which is unique and not known by user
```
* To upload files inside forms, we define ```form``` tags with an ```enctype``` parameter as
```<form action="" method="" enctype="multipart/form-data">```
* To get the ```url``` string after the website domain, one can use the ```flask feature``` as
```py
# Anything that comes after / which is of type string, store that inside the code variable
@app.route("/<string>=code")
def func(code):
    pass
```

# json
* This is a module, that can be used to write an dictionary inside of a file or read from a file
* The method of this module which is used is ```dump```
```py
# This code will write down the complete dictionary as json data in file
with open("file.json","w") as file:
    json.dump(dict,file)
```
* The method to read json file into a dictionary variable is ```load```
```py
# This code will read the complete json file into an dictionary variable
with open("file.json") as file:
    dictionary_variable = json.load(file)
```

# Route
* To refer to the path of url, we use ```route```
* Its syntax is like ```@app.route("url-path")```
* And followed by function which needs to be done on particular url
```py
#base url
@app.route('/')
def home():
    # html tags works properly
    return "<h1> Hello Flask! </h1>"
```
* We can route to same function using multiple ```url paths``` as
```py
#base url
@app.route('/')
@app.route("/index")
@app.route("/home")
def home():
    # html tags works properly
    return "<h1> Hello Flask! </h1>"
```

# render_template
* Used to display any html page upon ```routing``` to specific ```url```
* It can be imported from ```flask```
* It access the ```templates``` folder by default
```py
from flask import render_template
#render_template
@app.route("/path-to-route-to")
def function_Execute():
    return render_template("Html_file_name.html")
```
# redirect
* Another way to redirect the user to another page
* It is imported from the ```flask``` module as ```from flask import redirect```
```py
@app.route("/any-url")
def func():
    return rediect("/url-name-of-other-route")
```

# url_for
* This method is utilized to make the page redirection more dynamic
* Instead of providing path-name or url's of particular function, we provide the function name to be called
* It is imported from the ```flask``` module as ```from flask import url_for```
```py
from flask import redirect,url_for

@app.route("/any-url")
def func():
    return redirect(url_for("func2"))

def func2():
    pass
```

# Jinja
* it can be utilized to pass any variable to html pages
* you can define the variable-names inside the return statement and access the variable using ```{{ var-namr }}```
```py
# The app.py file

@app.route("/")
def func():
    return render_template("Hello_world.html")
```
```html
# The Hello_word.html file
<h1> This is the home page of {{ name }} </h1>
```
* To include code from any other file, we can use ```{% include "path-of-file" %}``` at any position in our code, its more like replacing the jinja with actual code on runtime
* To inherit structure from another file, we use ```extend``` as ```{% extends "filename" %}``` at the top of page
* The jinja inside an ```html``` can be re-used like any variable of class as ```{{ self.block-name }}```
* Basic Syntax:
    1. To get variable name: {{ varibale-name }}
    2. To use pre-defined terms like if,for,include,extend: {% %}
    3. Comment: {# #}
* For if-else
```
{% if condition %}
..statements
{% else %}
..statements
{% endif %}
```
* To call a web-page from an ```anchor tag <a>``` from inside an ```html page``` instead of giving path to the ```route url```, we can call the function name as ```<a href='{{ url_for("function-name") }}'>Keyword</a>```
* For Syntax
```
{% for i in Enumerable-Structure %}
..Statement
.. {{ i }}
..Statement
{% endfor %}
```

# Request
* ```Request``` object gives ```response``` in an ```JSON API``` format
* This method is used to get the form data from an ```HTML``` page
* The data can be taken from web-page through ```GET``` or ```POST``` method
* This method is imported from ```flask``` as ```from flask import request```

## Get Request
* To get any data from ```Get Request``` using forms, one can use ```request``` function
* To get any value from ```Get``` request, use ```request.args["input-field-name"]```
* ```args``` can be considered as an list with collection of all the items passed through get request
* Another way is ```request.args.get("input-field-name")```
* Best way is to use ```request.args.get``` as if no value is present then it gives ```None``` in return where as ```request.args[<name>]``` will crash your website if nothing is returned

## POST Request
* To get any value from ```POST``` request, use ```request.form["input-field-name"]```
* Or ```request.form.get("input-field-name")```
* Here ```request.form``` is a dictionary with the ```field_name``` as ```key``` and its ```value``` as ```pair```
* By default, ```flask``` only provides access to ```GET``` requests, so to use ```POST``` we need to explicitly define the same in the method
```py
@app.route("/url-path",methods=["GET","POST"])
def func():
    return render_template("file.html",var=request.form["input-field-name"])
```

# Response
* Response object is commonly used to create APIs
* A Response object provides following parameters
```py
class flask.Response(
    response=None, # most commonly used
    status=None,
    headers=None,
    mimetype=None,  # most commonly used
    content_type=None,  # most commonly used
    direct_passthrough=False
)
```

# Flash messages
* To send any particular message to html web-pages, we use the ```flash``` method from the ```flask``` module
* It is imported as ```from flask import flash```
* Inside a function, we just need to define ```flash("message for user")``` to call the flash function
* To use this message inside our ```HTML``` code, we define it as 
```html
<!-- this is the form JINJA used for flash messages -->
{% for messages in get_flashed_messages() %}
<h2> {{ messages }} </h2>
{% endfor %}
```

# File Uploads
* To upload any file in web programming, we use the ```file input type``` as ```<input type="file" name="field_name" value="" required>```
* The form is included with an another parameter called ```enctype``` as ```<form action="" method="" enctype="multipart/form-data">```
* To get the uploaded file in a variable, we can use any-variable name equal to ```request.file["file_field_name"]```
```py
f = request.file["file"]
```
* To get the filename , use ```fullname``` method
```py
f.fullname
```
* To check if the file is proper or not, that is it might have been uploaded for ```bad``` purpose like corrupting our data server, we can use ```secure_filename``` function as ```full_name = request.form["code"] + secure_filename(f.filename)```
* ```secure_filename``` can be imported from ```werkzeug``` as ```from werkzeug.utils import secure_filename```, it is a module made by the same as the developer of ```Flask```
* To save the file in our local system, we have ```save``` function ``` f.save("path-to-save-the-file")```


# Static Folder
* Any media files which could be images,audio,gifs,videos,logos etc
* Flask by default searches for such files inside the ```static folder``` available inside the project directory
* To redirect the url to static files, we use ```return redirect(url_for("static",filename="path-of-file"))```


# Error Pages
* By default, if page is not found the user is redirected to ```404-Not Found page```
* Or we can also redirect the user to the same using ```abort``` function
* ```abort``` can be imported as ```from flask import abort```
* Its used as ```return abort(404)```
* To display our own ```Error Page```, we would need to catch the error that is done using ```@app.errorhandler(error-code)```
```py
# 404 is being passed for the browser, to know that error has occurred
@app.errorhandler(404)
def page_not_found(error):
    return render_template("page_not_found.html"),404
```
* Over here, ```abort``` is more like ```throw``` and ```@app.errorhandler``` is like ```catch``` block


# Sessions and Cookies
* Cookies can be accessed using the method ```session```
* It is imported from ```flask``` as ```from flask import session```
* To save any information inside the cookies, just use ```session[request.form["code"]] = True```
* Here ```session``` is a dictionary imported from flask, and upon setting any keys value as ```True```, it gets added inside the ```cookies```


# Creating JSON APIs
* To create a json string, we can use ```jsonify``` method
* It can be imported from ```Flask``` as ```from flask import jsonify```
* ```jsonify``` can convert and ```list``` or ```dictionary``` to ```json string```

# Base Templates
* Base refers to the template files that can be re-used again and again
* It uses the ability of jinja, to render the page dynamically
* An Example of the base template would be
```html
<head>
    <title>{% block title %}{% endblock %}</title>
</head>

{% block main %}
{% endblock %}
```
* A Great website needs great looks, for which one can use ```bootstrap templates```
* For example, to give path to ```style-sheet```, do it as ```<link rel="stylesheet" href="{{ url_for('static', filename='bootstrap.min.css') }}">```
* Or to call any function, from the ```app.py```, just write ```<a class="p-2 text-dark" href="{{ url_for('session_api') }}">API</a>```


# Blueprints
* In a website, we don't usually work with single app instead we have multiple apps, each with its own function
* For this purpose, we use blueprint through which we connect multiple apps altogether
* Steps to add an app to your project
    1. Go to ```__init__.py``` file


# PyTest
* Helps to test the projects
* The test file name should be ```conftest.py```
* It contains information regarding the apps we want to test or any information we might need to test the app
* ```conftest.py``` file looks like this
```py
import pytest
from urlshort import create_app

# fixtures helps fixing the testing situation
@pytest.fixture
def app():
    app = create_app()
    yield app

@pytest.fixture
def client(app):
    return app.test_client()
```

* Another testing file can be created as ```test_main.py``` with code like
```py
from urlshort import create_app

'''
In this we can try if certain conditions are being followed or not
Like over here, its checking if shorten keyword is present in the webpage
and in similar way many different test cases can be made as per possible test conditions
'''

def test_shorten(client):
    response = client.get("/")
    assert b'Shorten' in response.data

```

# WSGI
* It stands for Web Server Gateway Interface
* It is a protocol that is used so that many servers and app frameworks can talk to each other
* Servers:
    1. Gunicorn
    2. uWSGI
* Frameworks:
    1. Flask
    2. Django
* To deploy the project, we are gonna use ```Gunicorn```

## Gunicorn
* Assuming things to be done on linux system
* Require the project folder
* Steps:
    1. Move into the working directory
    2. Run ```pipenv install```
    3. Run ```pipenv shell```
    4. Run ```export FLASK_APP=urlshort```
    5. Run ```flask run```
    6. After confirming things are working perfectly, press ```CTRL + C```
    7. Run ```flask run --host=0.0.0.0```
    8. Run ```pipenv install gunicorn```
    9. Run ```gunicorn "urlshort:create_app()" -b 0.0.0.0```
    10. Run ```sudo app install nginx```
    11. Run ```systemctl status nginx``` -> check if its active
    12. Run ```sudo nano /etc/nginx/sites-enables/default``` and copy 
    ```
    server {
    listen 80;
    server_name example.org;
    access_log  /var/log/nginx/example.log;

    location / {
        proxy_pass http://127.0.0.1:8000;
        proxy_set_header Host $host;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
    }
    }
    ```
    13. Run ```gunicorn "urlshort:create_app()" -b 0.0.0.0 --daemon``` -> to make sure gunicorn runs even if terminal is closed

# Full Stack Flask 

# General
* Install ```flask```, run ```pip install flask```
* Install ```flask-wtf```, run ```pip install flask-wtf``` -> used for creating forms easily
* Create a ```.flaskenv``` file and set the environment variables in this file ```FLASK_ENV=development``` and ```FLASK_APP=main.py``` (we can write anything in place of main.py)
* FLASK_APP defines the starting source of complete web application that is which apps need to be executed and in what way (the connectivity) among all apps is done through ```main.py``` here
* In order to run ```.flaskenv``` we would also need ```python-dotenv```
* To list all the system installed modules in an file, just run ```pip freeze > requirements.txt``` as ```pip freeze``` lists all the modules installed in the environment
* With help of ```.flaskenv``` file, we can just run our project using ```flask run```
* To pass multiple variables, we can send them as an object altogether and to create one the syntax is like
```py
object_name = {"var1":variable_name,"var2":var_name}

# To access the same we can use in html pages using jinja
object_name.var1
object_name.var2
```

# Simple Flask Application
* Every ```.py``` file in flask is called an module
* we can set multiple ```routes``` for a single function 
```py
from flask import Flask

# Special variable name to get that the current application is being rendered by flask
app = Flask(__name__)

@app.route("/")
@app.route("/index")
def index():
    return "<h1> Hello World !! </h1>"
```

# Confirguring Development Server
* Create an ```config.py``` file and set value as
```py
import os

class Config(object):
    SECRET_KEY = os.eniron.get('SECRET_KEY') or "secret_string"
```
* To get environment variable value, use ```os.eniron.get('SECRET_KEY')```
* This is used to setup the ```Secret Key``` in the ```config.py``` file
* Create a ```route.py``` file and set its value like
```py
from application import app

@app.route("/")
@app.route("/index")
def index():
    return "<h1> Hello World !! </h1>"
```
* Basically, all the ```routing-paths``` are now set in the ```routes.py``` file
* And in the ```__init__.py``` file, we define 
```py
from flask import Flask

# Special variable name to get that the current application is being rendered by flask
app = Flask(__name__)

from application import routes
```
* which defines that after running this application check for ```routes.py``` file for urls functioning


# URL Variables
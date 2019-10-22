from flask import Flask, render_template
from static import __SERVER_IP__, __SERVER_PORT_NUMBER__, __IS_DEBUGABLE__
from controller import helloWorld

app = Flask(__name__)



@app.route("/")
def default():
    return render_template("index.html")

@app.route('/helloWorld')
def index():
    return helloWorld()


if __name__ == '__main__':
    app.run(host=__SERVER_IP__, port=__SERVER_PORT_NUMBER__, debug=__IS_DEBUGABLE__)
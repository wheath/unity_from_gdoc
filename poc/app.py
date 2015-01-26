# import the Flask class from the flask module
from flask import Flask, render_template
import subprocess

# create the application object
app = Flask(__name__)

# use decorators to link the function to a url
@app.route('/')
def home():
    return render_template('home.html')  # render a template

@app.route('/build_game', methods=['POST'])
def build_game():
    subprocess.check_output(['sh', '/Users/student/work/unity_from_gdoc/poc/build_combined_game.sh'])
    return render_template('game.html')  # render a template

@app.route('/view_game')
def view_game():
    return render_template('game.html')  # render a template

# start the server with the 'run()' method
if __name__ == '__main__':
    #app.run(debug=True)
    app.run(host='0.0.0.0')


from flask import Flask
from algorithm import *


app = Flask(__name__)


@app.route('/')
def start_algorithm():
    return run_algorithm()


if __name__ == '__main__':
    app.run()

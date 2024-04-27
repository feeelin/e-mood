from flask import Flask,send_file, request, jsonify
from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)


app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///example.db'
db = SQLAlchemy(app)


@app.route('/get-track')
def get_track():
    return send_file("files/1.mp3")


@app.route('/generate-track', methods=['POST'])
def generate_track():
    return "Трек успешно сгенерирован."


if __name__ == '__main__':
    app.run(debug=True)


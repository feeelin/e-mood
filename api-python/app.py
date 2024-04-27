from flask import Flask, send_file, request, jsonify
from flask_sqlalchemy import SQLAlchemy
from diffusers import AudioLDM2Pipeline
from IPython.display import Audio
import torch
import scipy
import gradio as gr
import numpy as np
from scipy.io.wavfile import write
import numpy as np
import wave

app = Flask(__name__)

app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///example.db'
db = SQLAlchemy(app)


@app.route('/get-track')
def get_track():
    return send_file("files/1.mp3")


@app.route('/generate-track', methods=['GET'])
def generate_track():
    repo_id = "cvssp/audioldm2"
    pipe = AudioLDM2Pipeline.from_pretrained(
    repo_id,
    torch_dtype=torch.float16,
    ).to("cuda")
    prompt = "Создайте спокойную инструментальную музыку в стиле эмбиент."

    audio = pipe(prompt).audios[0]
    with wave.open('output.wav', 'wb') as wav_file:
        # Устанавливаем параметры файла
        wav_file.setnchannels(1)
        wav_file.setsampwidth(2)
        wav_file.setframerate(10000)

        # Записываем данные в файл
        wav_file.writeframes(audio.tobytes())
        return send_file('output.wav', mimetype='audio/wav')


if __name__ == '__main__':
    app.run(debug=True)
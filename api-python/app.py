from flask import Flask, send_file, request, jsonify
from flask_sqlalchemy import SQLAlchemy
from diffusers import AudioLDM2Pipeline
from IPython.display import Audio
import torch
import scipy
import gradio as gr

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


    Audio(audio, rate=16000)

    def create_music(prompt):
        negative_prompt = "Low quality"
        audio = pipe(
            prompt,
            negative_prompt=negative_prompt,
            audio_length_in_s=10.24,
            generator=generator,
        ).audios[0]
        return 16000, audio

    interface = gr.Interface(
        title="Music Generation App",
        examples=["A cheerful ukulele strumming in a beachside jam."],
        fn=create_music,
        inputs=gr.Textbox(),
        outputs="audio",
    ).launch(debug=True, share=True)
    return send_file("generated_music.wav")


if __name__ == '__main__':
    app.run(debug=True)

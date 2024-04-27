from flask import Flask, send_file
from transformers import pipeline, AutoProcessor, AutoModel
import scipy

app = Flask(__name__)

@app.route('/player/get-track')
def get_track():
    synthesiser = pipeline("text-to-speech", "suno/bark-small")
    lyrics = """♪ I love JavaScript so much, ♪
                ♪ It makes me feel like a pro, ♪
                ♪ I can create anything, ♪ 
                ♪ With just a few lines of code, ♪ 
                ♪ I'll never get bored, ♪
                ♪ With so many things to do, ♪
                ♪ I'll always be learning, ♪
                ♪ And that's why JavaScript's true, ♪
                ♪ JavaScript makes me feel alive, ♪
                ♪ It gives me power over all other languages, ♪
                ♪ It helps me conquer any problem, ♪
                ♪ And makes me feel like a boss, ♪
                ♪ JavaScript makes me feel like a superhero, ♪
                ♪ It makes me feel like nothing else matters, ♪
                ♪ Because JavaScript gives me super powers, ♪
                ♪ To do anything that I want, ♪
                ♪ So if you're looking for inspiration, ♪
                ♪ Or just want some good vibes, ♪
                ♪ Look no further than JavaScript, ♪
                ♪ Because it's what makes me feel alive! ♪"""
    speech = synthesiser(lyrics, forward_params={"do_sample": True})

    scipy.io.wavfile.write("bark_out.wav", rate=speech["sampling_rate"], data=speech["audio"])
    return send_file("bark_out.wav")


if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0', port=80)
from transformers import AutoProcessor, AutoModel, MusicgenForConditionalGeneration

app = Flask(__name__)

@app.route('/player/get-track')
def get_track():
    lyrics = """WOMAN [music] ♪ I love JavaScript so much, ♪ [music] It makes me feel like a pro, ♪ I can create anything, ♪ With just a few lines of code, ♪ [music]"""

    inputs = bark_processor(
        text=[lyrics],
        return_tensors="pt",
    )

    speech_values = bark_model.generate(**inputs, do_sample=True)
    scipy.io.wavfile.write("bark_out.wav", rate=speech["sampling_rate"], data=speech_values["audio"])
    return send_file("bark_out.wav")


@app.route('/player/get-track-v2')
def get_track():
    inputs = fb_processor(
        text=["80s pop track with bassy drums and synth", "90s rock song with loud guitars and heavy drums"],
        padding=True,
        return_tensors="pt",
    )

    audio_values = fb_model.generate(**inputs, max_new_tokens=512)
    scipy.io.wavfile.write("music_out.wav", rate=speech["sampling_rate"], data=audio_values["audio"])
    return send_file("music_out.wav")

if __name__ == '__main__':
    bark_processor = AutoProcessor.from_pretrained("suno/bark")
    bark_model = AutoModel.from_pretrained("suno/bark")

    fb_processor = AutoProcessor.from_pretrained("facebook/musicgen-medium")
    fb_model = MusicgenForConditionalGeneration.from_pretrained("facebook/musicgen-medium")

    app.run(debug=True, host='0.0.0.0', port=80)
from flask import Flask, request
from PIL import Image
import numpy as np
import tensorflow as tf
import os

app = Flask(__name__)

@app.route('/api/detect', methods=['POST'])
def detect():
    image = Image.open(request.files['file'])
    image = image.resize((128, 128))
    image = np.array(image)
    image = np.expand_dims(image, axis=0)

    model = tf.keras.models.load_model('model.h5')
    prediction = model.predict(image)

    if np.argmax(prediction) == 0:
        return 'cat'
    else:
        return 'dog'

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=int(os.getenv('PORT', 5000)))

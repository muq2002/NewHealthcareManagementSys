import sys
import numpy as np
from tensorflow.keras.models import load_model

def predict_liver_disease(data):
    model = load_model('./models/liver_scaled_model.h5')
    data = np.array(data).reshape(1, -1)
    prediction = model.predict(data)
    if prediction[0] == 1:
        return "Has Liver Disease"
    else:
        return "Healthy"

data = [float(arg) for arg in sys.argv[1:]]

print(predict_liver_disease(data))


#test samples
# python .\liver_model_runner.py 62 1 6.8 3.0 542 116 66 6.4 3.1 0.9
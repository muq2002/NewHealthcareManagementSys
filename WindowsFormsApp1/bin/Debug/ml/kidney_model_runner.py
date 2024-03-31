import sys
import numpy as np
from tensorflow.keras.models import load_model

def predict_kidney_disease(data):
    model = load_model('./models/kidney_model.h5')
    data = np.array(data).reshape(1, -1)
    prediction = model.predict(data)
    if prediction[0] == 1:
        return "Has Kidney Disease"
    else:
        return "Healthy"

data = [float(arg) for arg in sys.argv[1:]]

print(predict_kidney_disease(data))


#test samples
# python .\kidney_model_runner.py 48.0 80.0 1.020 1.0 0.0 1 1 0 0 121.0 36.0 1.2 142.0 5.6 15.4 44.0 7800.0 5.2 1 1 0 0 0 0

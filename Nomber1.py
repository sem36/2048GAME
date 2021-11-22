import scipy.signal
from scipy.signal import find_peaks

input_data = input()
data = input_data.split(",")
data_max = int(max(data))
peaks = find_peaks(data, height=(450, data_max))
count = len(peaks[0])
print(count)

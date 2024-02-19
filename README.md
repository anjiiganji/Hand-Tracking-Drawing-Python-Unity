

# Drawing App With Hand Tracking

The object of this project was to make a drawing app for desktop where the user can draw using their hands instead of a mouse. I used MediaPipe library by google to track the hands using python and sending that data over to the unity app through sockets. 

In the unity app, I am remaking the hand skeleton with the hand pose data that's recievevd from python and attached a line renderer to the index finger.

The line drawing logic will get triggered when the user presses "SPACE" bar.

Click below link to download the windows build
[Download](https://github.com/anjiiganji/Hand-Tracking-Drawing-Python-Unity/releases/download/latest/Build.zip)

In order to run the python script, Please install the following libraries

`pip install opencv-python`

`pip install mediapipe`

`pip install cvzone`

Run the python script before running the windows build or the unity project.

-Anjali Nair

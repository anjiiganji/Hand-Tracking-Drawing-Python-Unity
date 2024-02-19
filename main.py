import cv2
from cvzone.HandTrackingModule import HandDetector
import socket

cap=cv2.VideoCapture(0)
cap.set(3,1280)
cap.set(4,720)

detector=HandDetector(maxHands=1)
sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
server_address=('127.0.0.1',12347)

while True:
    success,img=cap.read()
    hands,img=detector.findHands(img)

    data = []

    if hands:
        hand=hands[0]
        handList=hand['lmList']

        for finger in handList:
            data.extend([finger[0],720-finger[1],finger[2]])
        sock.sendto(str.encode(str(data)),server_address)
        cv2.imshow('Image',img)
        cv2.waitKey(1)

# 윈도우 기본
import sys
from PyQt5.QtWidgets import *

class MyWindow(QMainWindow):
    def __init__(self):
        super().__init__()

app = QApplication(sys.argv)
win = MyWindow()
win.show()
app.exec_()

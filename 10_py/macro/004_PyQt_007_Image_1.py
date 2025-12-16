import sys
from PyQt5.QtWidgets import *
from PyQt5.QtGui import * # image

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(300,300,400,400)

        label = QLabel()
        label.setPixmap(QPixmap("./image/logo.jpg"))
        self.setCentralWidget(label)

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()
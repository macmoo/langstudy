import sys
from PyQt5.QtWidgets import *

class MyWin(QWidget):
    def __init__(self):
        super().__init__()

        btn1 = QPushButton("btn1")
        btn2 = QPushButton("btn2")
        btn3 = QPushButton("btn3")
        btn4 = QPushButton("btn4")

        layout = QGridLayout()
        layout.addWidget(btn1, 0,0)
        layout.addWidget(btn2, 0,1)
        layout.addWidget(btn3, 1,0)
        layout.addWidget(btn4, 1,1)

        self.setLayout(layout)

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()
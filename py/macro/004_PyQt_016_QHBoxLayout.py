import sys
from PyQt5.QtWidgets import *

class MyWin(QWidget):
    def __init__(self):
        super().__init__()

        btn1 = QPushButton("btn1")
        btn2 = QPushButton("btn2")
        btn3 = QPushButton("btn3")

        layout = QHBoxLayout()
        layout.addWidget(btn1)
        layout.addWidget(btn2)
        layout.addWidget(btn3)

        self.setLayout(layout)

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()
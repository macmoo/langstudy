import sys
from PyQt5.QtWidgets import *

# class MyWin(QMainWindow):
class MyWin(QWidget):
    def __init__(self):
        super().__init__()
        self.setGeometry(300,300,400,400)

        btn1 = QPushButton("btn1")
        btn2 = QPushButton("btn2")

        layout = QVBoxLayout()
        layout.addWidget(btn1)
        layout.addWidget(btn2)
        self.setLayout(layout)

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()
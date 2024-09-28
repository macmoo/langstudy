import sys
from PyQt5.QtWidgets import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(1000,400,400,300)

        btn = QPushButton("Trading Start", self)
        btn.setToolTip("Trading Start <b>Button</b>")
        btn.move(10,10)

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()

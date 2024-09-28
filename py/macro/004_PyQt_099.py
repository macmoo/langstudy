import sys
from PyQt5.QtWidgets import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(100,400,400,300)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    win = MyWin()
    win.show()
    app.exec_()

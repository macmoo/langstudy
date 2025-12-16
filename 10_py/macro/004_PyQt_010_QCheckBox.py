import sys
from PyQt5.QtWidgets import *
from PyQt5.QtGui     import *
from PyQt5.QtCore    import Qt

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(300,300,400,400)
        self.setWindowIcon(QIcon("./image/icon03.png"))

        self.cbox = QCheckBox("미수", self)
        self.cbox.move(10, 10)
        self.cbox.stateChanged.connect(self.slot)

    def slot(self, state):
        if state == Qt.Checked:
            print("미수")
        else:
            print("보통")


app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()

# https://wikidocs.net/71666
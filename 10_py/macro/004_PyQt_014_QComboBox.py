import sys
from PyQt5.QtWidgets import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(300,300,400,400)

        self.combo = QComboBox(self)
        self.combo.move(10,10)
        self.combo.resize(200,30)

        self.combo.addItem("보통")
        self.combo.addItem("시장가")
        self.combo.addItem("조건부지정가")
        self.combo.currentTextChanged.connect(self.slot)

    def slot(self, text):
        print(text)

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()
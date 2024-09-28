import sys
from PyQt5.QtWidgets import *
from PyQt5.QtGui import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowIcon(QIcon("./image/icon03.png"))
        self.setGeometry(300,300,400,400)

        self.line_edit = QLineEdit(" ", self)
        # self.line_edit.setEnabled(False) # 비활성화
        self.line_edit.setText("HELLO")
        self.line_edit.move(10,10)
        self.line_edit.textChanged.connect(self.text_changed)

    def text_changed(self):
        text = self.line_edit.text()
        print(text)

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()
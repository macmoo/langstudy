import sys
from PyQt5.QtWidgets import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(300,300,400,400)

        # Label
        self.label = QLabel("메시지:", self)
        self.label.move(10,10)

        # Button
        self.btn = QPushButton("click", self)
        self.btn.move(10,40)

        # signal-slot
        self.btn.clicked.connect(self.btn_clicked)

    def btn_clicked(self):
        self.label.clear()
        self.label.setText("버튼 클릭")

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()

# https://wikidocs.net/71659


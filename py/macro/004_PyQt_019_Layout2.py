import sys
from PyQt5.QtWidgets import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()

        btn1 = QPushButton("btn1")
        btn2 = QPushButton("btn2")

        widget = QWidget()
        layout = QVBoxLayout(widget)
        layout.addWidget(btn1)
        layout.addWidget(btn2)

        self.setCentralWidget(widget)

        # QWidgte->QVBoxLayout->QPushButton
        vbox = widget.findChildren(QVBoxLayout)[0]
        btn = vbox.itemAt(1).widget()
        print(btn.text()) # btn2

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()

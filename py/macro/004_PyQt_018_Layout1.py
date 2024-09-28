import sys 
from PyQt5.QtWidgets import *


class MyWindow(QMainWindow): # QMainWindow 상속
    def __init__(self):
        super().__init__() 

        btn1 = QPushButton('btn1')
        btn2 = QPushButton('btn2')

        widget = QWidget()
        layout = QVBoxLayout(widget)
        layout.addWidget(btn1)
        layout.addWidget(btn2)
        self.setCentralWidget(widget)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MyWindow()
    window.show()
    app.exec_()


# https://wikidocs.net/156100
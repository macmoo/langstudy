import sys
from PyQt5.QtWidgets import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(1000,400,400,300)

        listWidget = QListWidget()
        listWidget.addItems(["Python 3.7", "Python 3.8", "Python 3.9"])
        listWidget.currentItemChanged.connect(self.itemChanged)

        widget = QWidget()
        vbox = QVBoxLayout(widget)
        vbox.addWidget(listWidget)
        self.setCentralWidget(widget)

    def itemChanged(self, item):
        print(item.text())

if __name__ == "__main__":
    app = QApplication(sys.argv)
    win = MyWin()
    win.show()
    app.exec_()

import sys
from PyQt5.QtWidgets    import *
from PyQt5.QtGui        import QPixmap

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(1000,400,400,300)

        label = QLabel()
        label.setPixmap(QPixmap("./image/logo.jpg"))
        label.setScaledContents(True)
        button = QPushButton("click")

        widget = QWidget()
        vbox   = QVBoxLayout(widget)
        vbox.addWidget(label)
        vbox.addWidget(button)

        self.setCentralWidget(widget)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    win = MyWin()
    win.show()
    app.exec_()

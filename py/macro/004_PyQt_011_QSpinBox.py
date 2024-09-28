import sys
from PyQt5.QtWidgets import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(300,300,400,400)

        self.spinbox = QSpinBox(self)
        self.spinbox.move(10,10)
        self.spinbox.valueChanged.connect(self.spinbox_value_changed)

    def spinbox_value_changed(self):
        value = self.spinbox.value()
        print(value)

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()
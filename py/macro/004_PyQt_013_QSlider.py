import sys
from PyQt5.QtWidgets import *
from PyQt5.QtCore    import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(300,300,400,400)

        self.slider = QSlider(Qt.Horizontal, self)
        self.slider.setRange(0, 100)
        self.slider.move(10, 10)
        self.slider.valueChanged.connect(self.slider_value_changed)

    def slider_value_changed(self):
        value = self.slider.value()
        print(value)


app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()
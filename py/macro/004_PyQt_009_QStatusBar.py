import sys
from PyQt5.QtWidgets import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()

        # Status Bar
        self.statusBar = QStatusBar(self)
        self.setStatusBar(self.statusBar)
        # showMessage()     문자열을 상태바에 출력합니다.
        # currentMessage() 	상태바에 출력된 현재 메시지를 얻어옵니다.
        # clearMessage() 	상태바에 출력된 메시지를 지웁니다.
        self.statusBar.showMessage("PYSTOCK v1.0")
        print(self.statusBar.currentMessage())
        self.statusBar.clearMessage()

app = QApplication(sys.argv)
win = MyWin()
win.show()
app.exec_()
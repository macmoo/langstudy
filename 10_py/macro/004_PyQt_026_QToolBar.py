import sys
from PyQt5.QtWidgets import *
from PyQt5.QtGui     import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowIcon(QIcon("./image/icon03.png"))

        self.homeAction     = QAction(QIcon("./image/twitter.png"), 'home')
        self.homeAction.triggered.connect(self.close)

        self.settingAction  = QAction(QIcon("./image/facebook.png"), 'settings')
        self.settingAction.triggered.connect(self.setting)

        self.envelopeAction = QAction(QIcon("./image/youtube.png"), 'settings')
        self.envelopeAction.triggered.connect(self.envelope)

        #
        self.toolbar = self.addToolBar('title')
        self.toolbar.addAction(self.homeAction)
        self.toolbar.addSeparator()
        self.toolbar.addAction(self.settingAction)
        self.toolbar.addAction(self.envelopeAction)

    def setting(self):
        print('setting toolbar clicked')
    def envelope(self):
        print('envelope toolbar clicked')




if __name__ == "__main__":
    app   = QApplication(sys.argv)
    myWin = MyWin()
    myWin.show()
    app.exec_()
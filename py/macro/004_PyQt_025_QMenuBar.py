import sys
from PyQt5.QtWidgets import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(1000,400,400,300)

        self.menubar = self.menuBar()
        self.menubar.setNativeMenuBar(False)

        # file menu action
        self.newAction  = QAction("New")
        self.quitAction = QAction("Quit")
        self.quitAction.triggered.connect(self.close)

        # help menu action
        self.docAction     = QAction("Documentation")
        self.releaseAction = QAction("Release Notes")
        self.licenseAction = QAction("View License")

        # file menu
        fileMenu = self.menubar.addMenu("파일")
        fileMenu.addAction(self.newAction)
        fileMenu.addSeparator()
        fileMenu.addAction(self.quitAction)

        # help menu
        helpMenu = self.menubar.addMenu("도움말")
        helpMenu.addAction(self.docAction)
        helpMenu.addAction(self.releaseAction)
        helpMenu.addAction(self.licenseAction)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    win = MyWin()
    win.show()
    app.exec_()

# https://wikidocs.net/89416
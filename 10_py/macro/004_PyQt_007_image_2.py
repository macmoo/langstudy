# ---------------------------------------
# 참고
# ---------------------------------------
from PyQt5.QtWidgets import QApplication, QMainWindow, QWidget, QAction, QFileDialog, QGridLayout, QGraphicsView, QGraphicsScene
from PyQt5 import QtGui

import sys
import os

class MainWindow(QMainWindow):
    def __init__(self):
        super(MainWindow, self).__init__()

        # canvas
        self.canvas = Canvas()
        # canvasをMainWindowにセット
        self.setCentralWidget(self.canvas)

        self.setGeometry(300, 300, 500, 500)

        # menubarを作成
        self.createMenubar()

    def createMenubar(self):
        # menubar
        self.menubar = self.menuBar()

        # menubarにメニューを追加
        self.filemenu = self.menubar.addMenu('File')

        # アクションの追加
        self.openAction()

    def openAction(self):
        # アクションの作成
        self.open_act = QAction('開く')
        self.open_act.setShortcut('Ctrl+O') # shortcut
        self.open_act.triggered.connect(self.openFile) # open_actとメソッドを紐づける

        # メニューにアクションを割り当てる
        self.filemenu.addAction(self.open_act)

    def openFile(self):
        self.filepath = QFileDialog.getOpenFileName(self, 'open file', '', 'Images (*.jpeg *.jpg *.png *.bmp)')[0]
        print(self.filepath)
        if self.filepath:
            self.canvas.setImage(self.filepath)
            # 画像のサイズに応じてウィンドウサイズを変更
            self.resize(self.canvas.pixmap.width(), self.canvas.pixmap.height())

class Canvas(QWidget):
    def __init__(self):
        super(Canvas, self).__init__()

        # canvasのレイアウト
        self.canvas_layout = QGridLayout()

        # canvas_layoutをQWidget(self)にセット
        self.setLayout(self.canvas_layout)

        # 画像を表示するためのviewをレイアウトにセット
        self.view = QGraphicsView()
        self.scene = QGraphicsScene()
        self.view.setScene(self.scene)
        self.canvas_layout.addWidget(self.view)

    def setImage(self, filepath):
        img = QtGui.QImage()

        # 画像ファイルの読み込み
        if not img.load(filepath):
            return False

        # sceneの初期化
        self.scene.clear()

        # QImage -> QPixmap
        self.pixmap = QtGui.QPixmap.fromImage(img)

        # pixmapをsceneに追加
        self.scene.addPixmap(self.pixmap)

        # ウィジェットを更新
        self.update()

        return True

def main():
    app = QApplication(sys.argv)
    win = MainWindow()
    win.show()
    sys.exit(app.exec_())

main()
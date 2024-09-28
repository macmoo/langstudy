import sys
from PyQt5.QtWidgets import *
from PyQt5.QtGui     import * # icon

# 전역
# 버튼클릭시 호출 함수
def buy():
    print("몽땅 매수")

class MyWindow(QMainWindow):
    def __init__(self):
        super().__init__()

        # ----------------------------------------
        # 윈도우 타이틀
        self.setWindowTitle("My PyQT v1.0")
        # ----------------------------------------
        # 윈도우 사이즈
        self.setGeometry(300, 300, 400, 400)
        # ----------------------------------------
        # 타이틀바 아이콘
        # working
        #self.setWindowIcon(QIcon("D:/200.dev/201.src/20.python/py/macro/icon03.png"))
        # not working
        #self.setWindowIcon(QIcon("icon03.png"))
        self.setWindowIcon(QIcon('./image/icon03.png'))

        # ----------------------------------------
        # Button
        btnBuy = QPushButton(text="매수", parent=self)
        btnBuy.move(10,10)
        # btn.clicked.connect(buy) # 전역 메소드일 경우
        btnBuy.clicked.connect(self.buy) # 클래스 내의 메소드 호출
        # ----------------------------------------
        # 창닫기
        btnQuit = QPushButton(text="창닫기", parent=self)
        btnQuit.move(10,50)
        # 방법1
        # btnQuit.clicked.connect(QApplication.instance().quit)
        # 방법2
        # btnQuit.clicked.connect(self.btn_clicked)
        # 방법3
        btnQuit.clicked.connect(self.close)
    # 방법2
    def btn_clicked(self):
        QApplication.instance().quit()

    def buy(self):
        print("몽땅 매수")
 
# print(sys.argv)
print("출력-1")
app = QApplication(sys.argv)
win = MyWindow()
win.show()
print("출력-2")
app.exec_()
print("출력-3")


# https://wikidocs.net/70844
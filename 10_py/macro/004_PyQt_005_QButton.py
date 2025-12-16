import sys
from PyQt5.QtWidgets import *


class MyWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(300, 300, 400, 400)

        btn = QPushButton("종료", self)
        btn.move(20,20)
        btn.clicked.connect(self.btn_clicked)

        # 버튼 크기 조절
        btn.resize(100,150)

        # 활성/비활성화
        btn.setDisabled(True)
        btn.setEnabled(True)

        # 버튼의 텍스트 값
        btn2 = QPushButton("button2", self)
        btn2.move(20,300)
        print(btn2.text()) # button2 출력

    def btn_clicked(self):
        print("버튼클릭")
        # print(self)
        # self.resize(200,300)      # 윈도우 사이즈가 바뀜
        # self.btn.resize(200,300)  # ERROR
        self.close()


app = QApplication(sys.argv)
win = MyWindow()
win.show()
app.exec_()
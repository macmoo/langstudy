import sys
from PyQt5.QtWidgets import *
# QtWidgets 모듈에는 QApplication 클래스가 정의되어 있습니다.
# 현재 소스코드 파일에 대한 경로를 담고 있는 파이썬 리스트를 클래스의 생성자로 전달합니다.
# PyQt5를 이용한 모든 프로그램은 반드시 QApplication 객체를 생성해야한다.

print(sys.argv)
# => ['d:/200.dev/201.src/20.python/py/macro/0209_04_PyQt.py']

app = QApplication(sys.argv)
win = QWidget()
win.show()

# 이벤트 루프 시작,  '닫기' 버틑을 누를 때 까지 계속 실행
app.exec_()


# https://wikidocs.net/119616

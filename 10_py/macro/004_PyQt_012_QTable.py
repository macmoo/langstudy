import sys
from PyQt5.QtWidgets import *

class MyWin(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setGeometry(300,300,400,400)

        self.tableWidget = QTableWidget(self)
        self.tableWidget.resize(290, 290)
        self.tableWidget.setColumnCount(2)
        self.tableWidget.setRowCount(5)
        self.tableWidget.verticalHeader().setVisible(False)

        # 테이블 항목명
        labels = ["종목명", "종목코드"]
        self.tableWidget.setHorizontalHeaderLabels(labels)

        self.tableWidget.setItem(0,0,QTableWidgetItem("삼성전자"))
        self.tableWidget.setItem(0,1,QTableWidgetItem("005930"))
        self.tableWidget.setItem(1,0,QTableWidgetItem("SK하이닉스"))
        self.tableWidget.setItem(1,1,QTableWidgetItem("000660"))
        self.tableWidget.setItem(2,0,QTableWidgetItem("NAVER"))
        self.tableWidget.setItem(2,1,QTableWidgetItem("035420"))

# print(__name__)
if __name__ == "__main__":
    app = QApplication(sys.argv)
    win = MyWin()
    win.show()
    app.exec_()
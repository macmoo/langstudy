# 파이썬 메모

> * type()      : 자료형 확인
> * len()       : 문자열 길이
> * "//" 연산자 : 소수점 아래 버림
> * input()     : 사용자 입력 받음
> * int(), float(), str()   : 형변환
> * upper(), lower()
> * strip()     : 앞뒤 공백제거, lstrip(), rstrip()
> * 문자열 구성확인
>> * isalnum()
>> * isalpha()
>> * isidentifier()
>> * isdecimal()
>> * isdigit()
>> * issapce()
>> * islower()
>> * isupper()
> * find(), rfind()
> * "in"연산자  : 문자열내부 문자열 존재 확인
> * split()
> * f'문자열{표현식}문자열'
> * "*"         : 전개연산자
> * "pass"      : = todo
> * "raise NotImplementedError"
> * append(), insert()  : 리스트에 요소 추가
> * 
> * 
> * 
|제목|내용|
|------|---|
|리스트 |append(), insert(), extend()|
|-|del 리스트명[idx], pop(idx)|
|-|remove(val)|
|-|clear()|
|-|sort(), sort(reverse=True)|
|-|in / not in 연산자 => 값 in 리스트|
|리스트 슬라이싱|리스트[시작idx:끝idx:단계]|
|-|numbers[0:5:2]|
|반복문||
|for|for 반복자 in 반복할 수 있는 것|
|-|for i in Range(100):|
|-||
|전개 연산자|*|
|-|c = [*a,5,6,7]|
|-||

# PyQt
> * PyQt에서는 사용자가 버튼을 클릭하는 행위를 '시그널'이라고 하고 버튼을 클릭했을 때 수행할 함수를 '슬롯'이라고 합니다.
> * 이벤트루프에 의해 호출 당하는 함수를 콜백(callback) 함수라고 부릅니다.
> * Window Icon : 16 x 16
> *
> *
> *
> *
> *
> *
> *
> *
|제목|내용|
|------|---|
|타이틀바 아이콘        |self.setWindowIcon(QIcon('./macro/icon03.png'))|
|윈도우 사이즈         |self.setGeometry(300,300,400,400)|
|버튼                |btnBuy = QPushButton(text="매수", parent=self)|
|                   |self.btn.clicked.connect(self.btn_clicked)|
|창닫기               |btnQuit.clicked.connect(QApplication.instance().quit)|
|                   |btnQuit.clicked.connect(self.btn_clicked)|
|                   |btnQuit.clicked.connect(self.close)|
|라벨                |self.label = QLabel("메시지:", self)|
|                   |self.label.clear()|
|                   |self.label.setText("버튼 클릭")|
|setPixmap          |label.setPixmap(QPixmap("./macro/logo.jpg"))|
|                   |label.setScaledContents(True)|
|                   |self.setCentralWidget(label)|
|QLineEdit          |self.line_edit = QLineEdit(" ", self)|
|                   |self.line_edit.setEnabled(False) # 비활성화|
|                   |self.line_edit.setText("HELLO")|
|                   |text = self.line_edit.text()|
|QStatusBar         |self.statusBar = QStatusBar(self)|
|                   |self.setStatusBar(self.statusBar)|
|                   |self.statusBar.showMessage("PYSTOCK v1.0")|
|                   |print(self.statusBar.currentMessage())|
|                   |self.statusBar.clearMessage()|
|QCheckBox          |self.cbox = QCheckBox("미수", self)|
|                   |self.cbox.stateChanged.connect(self.slot)|
|                   |if state == Qt.Checked:|
|QSpinBox           |self.spinbox = QSpinBox(self)|
|                   |self.spinbox.valueChanged.connect(self.spinbox_value_changed)|
|                   |value = self.spinbox.value()|
|QTableWidget       |self.tableWidget = QTableWidget(self)|
|                   |self.tableWidget.resize(290, 290)|
|                   |self.tableWidget.setColumnCount(2)|
|                   |self.tableWidget.setRowCount(5)|
|                   |self.tableWidget.verticalHeader().setVisible(False)|
|                   |labels = ["종목명", "종목코드"] # 테이블 항목명|
|                   |self.tableWidget.setHorizontalHeaderLabels(labels)|
|                   |self.tableWidget.setItem(0,0,QTableWidgetItem("삼성전자"))|
|QSlider            |self.slider = QSlider(Qt.Horizontal, self)|
|                   |self.slider.setRange(0, 100)|
|                   |self.slider.valueChanged.connect(self.slider_value_changed)|
|                   |value = self.slider.value()|
|QComboBox          |self.combo = QComboBox(self)
|                   |self.combo.addItem("보통")
|                   |self.combo.currentTextChanged.connect(self.slot)
|                   |print(text)
|QVBoxLayout        |btn1 = QPushButton("btn1")|
|                   |layout = QVBoxLayout()|
|                   |layout.addWidget(btn1)|
|                   |self.setLayout(layout)|
|QHBoxLayout        |btn1 = QPushButton("btn1")|
|                   |layout = QHBoxLayout()|
|                   |layout.addWidget(btn1)|
|                   |self.setLayout(layout)|
|QGridLayout        |btn1 = QPushButton("btn1")|
|                   |layout = QGridLayout()|
|                   |layout.addWidget(btn1, 0,0)|
|                   |self.setLayout(layout)|
|Layout 여백?        |layout.addStretch(1)|
|QPlainTextEdit     |self.text = QPlainTextEdit(self)
|                   |self.text.appendPlainText("Hello\n") # 텍스트 출력
|                   |self.text.setReadOnly(True)|
|Theme             |app.setStyle("Fusion")|
|                  |palette = QPalette()|
|                  |palette.setColor(QPalette.Window,           QColor(53,53,53))|
|                  |palette.setColor(QPalette.Window,           QColor(53, 53, 53))|
|                  |palette.setColor(QPalette.WindowText,       Qt.white)|
|                  |palette.setColor(QPalette.Base,             QColor(25, 25, 25))|
|                  |palette.setColor(QPalette.AlternateBase,    QColor(53, 53, 53))|
|                  |palette.setColor(QPalette.ToolTipBase,      Qt.white)|
|                  |palette.setColor(QPalette.ToolTipText,      Qt.white)|
|                  |palette.setColor(QPalette.Text,             Qt.white)|
|                  |palette.setColor(QPalette.Button,           QColor(53, 53, 53))|
|                  |palette.setColor(QPalette.ButtonText,       Qt.white)|
|                  |palette.setColor(QPalette.BrightText,       Qt.red)|
|                  |palette.setColor(QPalette.Link,             QColor(42, 130, 218))|
|                  |palette.setColor(QPalette.Highlight,        QColor(42, 130, 218))|
|                  |palette.setColor(QPalette.HighlightedText,  Qt.black)|
|                  |app.setPalette(palette)
|QTabWidget        |tabs = QTabWidget()
|                  |tab1 = QWidget()
|                  |tabs.addTab(tab1, "tab1")
|                  |label1 = QLabel("Tab1 Widget" , tab1)
|                  |label1.move(10,10)
|                  |self.setCentralWidget(tabs)
|QListWidget       |listWidget = QListWidget()|
|                  |listWidget.addItems(["Python 3.7", "Python 3.8", "Python 3.9"])|
|                  |listWidget.currentItemChanged.connect(self.itemChanged)|
|                  |print(item.text())|
|Menu Bar          |self.menubar = self.menuBar()|
|                  |self.menubar.setNativeMenuBar(False)|
|                  |# file menu action|
|                  |self.newAction  = QAction("New")|
|                  |# file menu|
|                  |fileMenu = self.menubar.addMenu("파일")|
|                  |fileMenu.addAction(self.newAction)|
|                  |fileMenu.addSeparator()|
|Tool Bar          |self.homeAction = QAction(QIcon("./twitter.png"), 'home')|
|                  |self.toolbar = self.addToolBar('title')|
|                  |self.toolbar.addAction(self.homeAction)|
|                  |self.toolbar.addSeparator()|
|||
|||
|||
|||

# 참고
> https://seday.tistory.com/45
>
> https://wikidocs.net/85581
>
> https://brownbears.tistory.com/198
>
> https://www.inflearn.com/course/%ED%8C%8C%EC%9D%B4%EC%8D%AC-%ED%81%AC%EB%A1%A4%EB%A7%81-%EA%B8%B0%EC%B4%88
>
> ■ PyQt<br>
> https://wikidocs.net/119616
>
> ■ 아이콘<br>
> https://www.iconfinder.com
>
> ■ 마크다운<br>
> https://inasie.github.io/it%EC%9D%BC%EB%B0%98/%EB%A7%88%ED%81%AC%EB%8B%A4%EC%9A%B4-%ED%91%9C-%EB%A7%8C%EB%93%A4%EA%B8%B0/
>
>
>
>
>
>
>
>
>

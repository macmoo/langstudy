import sys
from PyQt5.QtWidgets import *
app = QApplication(sys.argv)
# -------------------------------------
# QPushButton
button = QPushButton("button")
button.show()
# -------------------------------------
# QLabel
label = QLabel("Label")
label.show()
# -------------------------------------
app.exec_()
